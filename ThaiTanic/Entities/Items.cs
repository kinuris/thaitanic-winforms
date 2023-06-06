using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace ThaiTanic.Entities
{
    public enum ItemCategory
    {
        Invalid,
        Breakfast,
        Burgers,
        Dessert,
        Drinks,
        Alcohol,
        MainCourse,
        Pasta
    }

    public static class ItemCategoryMethods
    {
        public static string AsString(this ItemCategory category)
        {
            switch (category)
            {
                case ItemCategory.MainCourse:
                    return "Main Course";
                default:
                    return category.ToString();
            }
        }
    }

    [DataContract]
    public class Items
    {
        [DataMember]
        public int Id;

        [DataMember]
        public string Name;

        [DataMember]
        public string Description;

        [DataMember]
        public decimal Price;

        [DataMember]
        public ItemCategory Category;

        [DataMember]
        public bool Available;

        [DataMember]
        public DateTime CreatedAt;

        [DataMember]
        public DateTime UpdatedAt;

        // Syncs object with corresponding table record

        public void UpdateItem(string name, string description, decimal price, ItemCategory category, bool available, string username, string password)
        {
            var user = User.AuthUser(username, password);

            if (user == null || user.Role != UserRole.Admin)
            {
                // TODO: 
                return;
            }

            string sql = "UPDATE items SET name = @name, description = @description, price = @price, category = @category, available = @available WHERE id = @id";

            // TODO: Handle failure and id not existing case
            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@category", category.ToString());
                cmd.Parameters.AddWithValue("@available", available);
                cmd.Parameters.AddWithValue("@id", Id);

                cmd.ExecuteNonQuery();
            }

            Fetch();
        }

        public void Fetch()
        {
            string sql = "SELECT id, name, description, price, category, created_at, updated_at, available FROM items WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();

                var reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    // TODO: Handle error when item is already deleted from database
                    return;
                }

                var item = new Items(reader);

                Name = item.Name;
                Description = item.Description;
                Price = item.Price;
                Category = item.Category;
                CreatedAt = item.CreatedAt;
                UpdatedAt = item.UpdatedAt;
            }
        }

        // NOTE: This needs the username and password, because ONLY admins should be able to create items
        // Create a new record in the table
        public static bool CreateItem(string name, string description, decimal price, ItemCategory category, bool available, string username, string password)
        {
            string sql = "INSERT INTO items (name, description, price, category, available) VALUES (@name, @description, @price, @category, @available)";

            User user = User.AuthUser(username, password);

            if (user == null || user.Role != UserRole.Admin) return false;

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@available", available);

                cmd.ExecuteNonQuery();

                // TODO: Handle Errors
            }

            return true;
        }

        //public static List<Items> GetByCategory(ItemCategory category)
        //{
        //    string sql = "SELECT id, name, description, price, category, created_at, updated_at, available FROM items WHERE category = @category";

        //    using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
        //    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
        //    {
        //        conn.Open();

        //        var reader = cmd.ExecuteReader();
        //        var result = new List<Items>();

        //        while (reader.Read())
        //            result.Add(new Items(reader));

        //        return result;
        //    }
        //}

        public static List<Items> GetAllItems()
        {
            string sql = "SELECT id, name, description, price, category, created_at, updated_at, available FROM items";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();

                var reader = cmd.ExecuteReader();
                var result = new List<Items>();

                while (reader.Read())
                    result.Add(new Items(reader));

                return result;
            }
        }

        public static Items GetItemById(int id)
        {
            string sql = "SELECT id, name, description, price, category, created_at, updated_at, available FROM items WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                    return new Items(reader);
                else
                    return null;
            }
        }

        // Converts MySql enum to corresponding C# Enum
        private static ItemCategory ParseItemCategory(string item)
        {
            switch (item.ToLower())
            {
                case "breakfast":
                    return ItemCategory.Breakfast;
                case "burgers":
                    return ItemCategory.Burgers;
                case "dessert":
                    return ItemCategory.Dessert;
                case "drinks":
                    return ItemCategory.Drinks;
                case "alcohol":
                    return ItemCategory.Alcohol;
                case "main course":
                    return ItemCategory.MainCourse;
                case "pasta":
                    return ItemCategory.Pasta;
            }

            return ItemCategory.Invalid;
        }

        public Items(MySqlDataReader reader, int offset)
        {
            Id = reader.GetFieldValue<int>(offset);
            Name = reader.GetFieldValue<string>(offset + 1);
            Description = reader.GetFieldValue<string>(offset + 2);
            Price = reader.GetDecimal(offset + 3);
            Category = ParseItemCategory(reader.GetFieldValue<string>(offset + 4));
            CreatedAt = reader.GetDateTime(offset + 5);
            UpdatedAt = reader.GetDateTime(offset + 6);
            Available = reader.GetFieldValue<bool>(offset + 7);
        }

        public Items(MySqlDataReader reader): this(reader, 0) {}
    }
}
