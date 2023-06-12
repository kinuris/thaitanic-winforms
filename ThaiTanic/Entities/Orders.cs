using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ThaiTanic.State;

namespace ThaiTanic.Entities
{
    public enum OrderStatus
    {
        ToPay,
        ToShip,
        ToRecieve,
        Completed,
        Cancelled,
        Invalid
    }

    public static class OrderStatusMethods
    {
        public static string AsString(this OrderStatus status)
        {
            switch (status)
            {
                case OrderStatus.ToPay:
                    return "To Pay";
                case OrderStatus.ToShip:
                    return "To Ship";
                case OrderStatus.ToRecieve:
                    return "To Recieve";
                default:
                    return status.ToString();
            }
        }

        public static string CorrectedString(this OrderStatus status)
        {
            switch (status)
            {
                case OrderStatus.ToPay:
                    return "To Pay";
                case OrderStatus.ToShip:
                    return "To Ship";
                case OrderStatus.ToRecieve:
                    return "To Receive";
                case OrderStatus.Cancelled:
                    return "Canceled";
                default:
                    return status.ToString();
            }
        }
    }

    // TODO: Add ability to change Orders.Status

    internal class Orders
    {
        public int Id;
        public DateTime DateOrdered;
        public decimal TotalPrice;
        public User Initiator;
        public BillingAddress AssociatedAddress;
        public OrderStatus Status;

        // Retrieves the batch associated with the order
        // Example Usage: Orders.GetOrderById(15).GetBatch() -> List<OrderBatch>
        public List<OrderBatch> GetBatch()
        {
            string sql = @"SELECT i.id, i.name, i.description, i.price, i.category, i.created_at, i.updated_at, ob.id, ob.quantity FROM 
                orders AS o INNER JOIN order_batch AS ob 
                ON o.id = ob.order_fid INNER JOIN items AS i ON ob.item_fid = i.id WHERE ob.order_fid = @order_id";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@order_id", Id);

                var reader = cmd.ExecuteReader();
                var result = new List<OrderBatch>();

                while(reader.Read())
                {
                    var assocItem = new Items(reader);
                    result.Add(new OrderBatch(reader, assocItem, 7));
                }

                return result;
            }
        }

        // TODO: Finalize
        public string GenerateReceipt()
        {
            var batches = GetBatch();
            var resultReceipt = "CHARLES POS\n\n";

            foreach (var batch in batches)
            {
                resultReceipt += $"{batch.AssociatedItem.Name} x {batch.Quantity}\n";
            }

            return resultReceipt;
        }

        public void SetStatus(OrderStatus status)
        {
            string sql = @"UPDATE orders SET status = @status WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@status", status.AsString());
                cmd.Parameters.AddWithValue("@id", Id);

                cmd.ExecuteNonQuery();
                Status = status;
            }
        }

        public static List<Orders> OrdersByUser(User user)
        {
            string sql = @"SELECT id, date_ordered, total_price, user_fid, billing_address_fid, status FROM orders
                         WHERE user_fid = @id";
            // TODO:

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@id", user.Id);

                var reader = cmd.ExecuteReader();
                var result = new List<Orders>();

                while (reader.Read())
                    result.Add(new Orders(reader));

                return result;
            }
        }

        public static Orders GetOrderById(int id)
        {
            string sql = "SELECT id, date_ordered, total_price, user_fid, billing_address_fid, status FROM orders WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                    return new Orders(reader);
                else
                    return null;
            }
        }

        // Example Usage: Orders.CreateOrder(user, Cart.Items)
        public static bool CreateOrder(User initiator, BillingAddress address, List<CartEntry> entries)
        {
            string insertOrderSql = "INSERT INTO orders (date_ordered, total_price, user_fid, billing_address_fid, status) VALUES (@date_ordered, @total_price, @user_fid, @billing_address_fid, @status); SELECT LAST_INSERT_ID()";
            decimal totalPrice = entries.Select(entry => entry.Item.Price * entry.Quantity).Sum();
            int insertedOrderId;

            // TODO: Handle Errors

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(insertOrderSql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@date_ordered", DateTime.Now);
                cmd.Parameters.AddWithValue("@total_price", totalPrice);
                cmd.Parameters.AddWithValue("@user_fid", initiator.Id);
                cmd.Parameters.AddWithValue("@billing_address_fid", address.Id);
                cmd.Parameters.AddWithValue("@status", OrderStatus.ToPay.AsString());

                insertedOrderId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            // SQL injection IS NOT POSSIBLE
            string insertOrderBatchSql = "INSERT INTO order_batch (item_fid, order_fid, quantity) VALUES ";
            List<string> itemsSql = entries.Select(entry => $"({entry.Item.Id}, {insertedOrderId}, {entry.Quantity})").ToList();

            insertOrderBatchSql += string.Join(", ", itemsSql);

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(insertOrderBatchSql, conn))
            {
                conn.Open();

                cmd.ExecuteNonQuery();
            }

            return true;
        }

        public static OrderStatus ParseOrderStatus(string status)
        {
            switch (status)
            {
                case "To Pay":
                    return OrderStatus.ToPay;
                case "To Ship":
                    return OrderStatus.ToShip;
                case "To Recieve":
                    return OrderStatus.ToRecieve;
                case "Completed":
                    return OrderStatus.Completed;
                case "Cancelled":
                    return OrderStatus.Cancelled;
                default:
                    return OrderStatus.Invalid;
            }
        }

        public Orders(MySqlDataReader reader, int offset)
        {
            Id = reader.GetFieldValue<int>(offset);
            DateOrdered = reader.GetDateTime(offset + 1);
            TotalPrice = reader.GetDecimal(offset + 2);
            Initiator = User.GetUserById(reader.GetFieldValue<int>(offset+ 3));
            AssociatedAddress = BillingAddress.GetAddressById(reader.GetFieldValue<int>(offset + 4));
            Status = ParseOrderStatus(reader.GetFieldValue<string>(offset + 5));
        }

        public Orders(MySqlDataReader reader) : this(reader, 0) {}

        // When creating a record an array of Order (BatchOrders) must be serialized into BatchOrders table
    }
}
