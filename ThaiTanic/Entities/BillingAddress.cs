using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiTanic.Entities
{
    internal class BillingAddress
    {
        public int Id;
        public User AssociatedUser;
        public string FullName;
        public string PhoneNumber;
        public string Region;
        public string Province;
        public string City;
        public string Barangay;
        public string PostalCode;

        public static List<BillingAddress> BillingAddressesOfUser(User user)
        {
            string sql = "SELECT id, user_fid, full_name, phone_number, region, province, city, barangay, postal_code FROM `BILLING_ADDRESS` WHERE user_fid = @user_fid";

            using (var conn = new MySqlConnection(Connection.ConnectionString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user_fid", user.Id);

                    var result = new List<BillingAddress>();
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                        result.Add(new BillingAddress(reader));

                    return result;
                }
            }
        }

        public static BillingAddress GetAddressById(int id)
        {
            string sql = "SELECT id, user_fid, full_name, phone_number, region, province, city, barangay, postal_code FROM `BILLING_ADDRESS` WHERE id = @id";

            using (var conn = new MySqlConnection(Connection.ConnectionString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                        return new BillingAddress(reader);
                    else
                        return null;
                }
            }
        }

        public BillingAddress(MySqlDataReader reader, int offset)
        {
            Id = reader.GetFieldValue<int>(offset);
            AssociatedUser = User.GetUserById(reader.GetFieldValue<int>(offset + 1));
            FullName = reader.GetFieldValue<string>(offset + 2);
            PhoneNumber = reader.GetFieldValue<string>(offset + 3);
            Region = reader.GetFieldValue<string>(offset + 4);
            Province = reader.GetFieldValue<string>(offset + 5);
            City = reader.GetFieldValue<string>(offset + 6);
            Barangay = reader.GetFieldValue<string>(offset + 7);
            PostalCode = reader.GetFieldValue<string>(offset + 8);
        }

        public BillingAddress(MySqlDataReader reader): this(reader, 0) { }
    }
}
