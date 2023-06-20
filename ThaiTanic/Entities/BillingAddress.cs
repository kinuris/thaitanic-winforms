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

        public string Summary
        {
            get
            {
                return $"{FullName} - {Province}, {City} {PostalCode}, {Barangay}";
            }
        }

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

        public void UpdateBillingAddress(string addressLabel, string region, string city, string postalCode, string phoneNumber, string province, string barangay)
        {
            string sql = "UPDATE `BILLING_ADDRESS` SET full_name = @full_name, phone_number = @phone_number, region = @region, province = @province, city = @city, barangay = @barangay, postal_code = @postal_code " +
                        "WHERE id = @id";

            using (var conn = new MySqlConnection(Connection.ConnectionString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@full_name", addressLabel);
                    cmd.Parameters.AddWithValue("@phone_number", phoneNumber);
                    cmd.Parameters.AddWithValue("@region", region);
                    cmd.Parameters.AddWithValue("@province", province);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@barangay", barangay);
                    cmd.Parameters.AddWithValue("@postal_code", postalCode);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void CreateBillingAddress(User user, string addressLabel, string region, string city, string postalCode, string phoneNumber, string province, string barangay)
        {
            string sql = @"INSERT INTO `BILLING_ADDRESS` (user_fid, full_name, phone_number, region, province, city, barangay, postal_code)
                            VALUES (@user_id, @full_name, @phone_number, @region, @province, @city, @barangay, @postal_code)";

            using (var conn = new MySqlConnection(Connection.ConnectionString))
            {
                conn.Open();

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", user.Id);
                    cmd.Parameters.AddWithValue("@full_name", addressLabel);
                    cmd.Parameters.AddWithValue("@phone_number", phoneNumber);
                    cmd.Parameters.AddWithValue("@region", region);
                    cmd.Parameters.AddWithValue("@province", province);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@barangay", barangay);
                    cmd.Parameters.AddWithValue("@postal_code", postalCode);

                    cmd.ExecuteNonQuery();
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

        public override string ToString()
        {
            return Summary;
        }
    }
}
