using MySql.Data.MySqlClient;
using System;
using System.Linq;

public enum UserRole
{
    Admin,
    User
}

namespace ThaiTanic.Entities
{
    public class User
    {
        public int Id;
        public string Username;
        public string FirstName;
        public string LastName;
        public string MiddleName;
        public DateTime Birthday;
        public int Age;
        public string Email;
        public string PhoneNumber;
        public UserRole Role;
        public DateTime CreatedAt;
        public DateTime UpdatedAt;

        public string FullName
        {
            get
            {
                return string.IsNullOrWhiteSpace(MiddleName) ? $"{FirstName} {LastName}" : $"{FirstName} {MiddleName.First()}. {LastName}";
            }
        }

        public static User GetUserById(int id)
        {
            string sql = @"SELECT id, username, first_name, last_name, middle_name, phone_number, birthday, email, role_enum, created_at, updated_at 
                        FROM user WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                    return new User(reader);
                else
                    return null;
            }
        }

        public static bool AssertUserExistsByUsername(string username)
        {
            string sql = @"SELECT id, username, first_name, last_name, middle_name, phone_number, birthday, email, role_enum, created_at, updated_at 
                        FROM user WHERE username = @username";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@username", username);

                return cmd.ExecuteReader().Read();
            }
        }

        public static bool AssertUserExistsById(int id)
        {
            string sql = @"SELECT id, username, first_name, last_name, middle_name, phone_number, birthday, email, role_enum, created_at, updated_at 
                        FROM user WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteReader().Read();
            }
        }

        public static bool CreateUser(string username, string password, string firstName, string lastName, 
            string middleName, string phoneNumber, DateTime birthday, string email) 
        {
            string sql = @"INSERT INTO user (username, password, first_name, last_name, middle_name, phone_number, birthday, email, role_enum) VALUES 
                        (@username, MD5(@password), @first_name, @last_name, @middle_name, @phone_number, @birthday, @email, 'user')";

            if(AssertUserExistsByUsername(username))
            {
                return false;
            }

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@first_name", firstName);
                cmd.Parameters.AddWithValue("@last_name", lastName);
                cmd.Parameters.AddWithValue("@middle_name", middleName);
                cmd.Parameters.AddWithValue("@phone_number", phoneNumber);
                cmd.Parameters.AddWithValue("@birthday", birthday);
                cmd.Parameters.AddWithValue("@email", email);

                cmd.ExecuteNonQuery();
            }

            return true;
        }

        // Finds the user with the passed username and password
        public static User AuthUser(string username, string password)
        {
            string sql = @"SELECT id, username, first_name, last_name, middle_name, phone_number, birthday, email, role_enum, created_at, updated_at
                        FROM user WHERE username = @username AND password = MD5(@password)";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                    return new User(reader);
                else
                    return null;
            }
        }

        public User(MySqlDataReader reader, int offset)
        {
            Id = reader.GetFieldValue<int>(offset);
            Username = reader.GetFieldValue<string>(offset + 1);
            FirstName = reader.GetFieldValue<string>(offset + 2);
            LastName = reader.GetFieldValue<string>(offset + 3);

            if (reader.IsDBNull(offset + 4))
            {
                MiddleName = null;
            } else
            {
                MiddleName = reader.GetFieldValue<string>(offset + 4);
            }

            PhoneNumber = reader.GetFieldValue<string>(offset + 5);
            Birthday = reader.GetDateTime(offset + 6);
            Email = reader.GetFieldValue<string>(offset + 7);
            Role = reader.GetFieldValue<string>(offset + 8) == "admin" ? UserRole.Admin : UserRole.User;
            CreatedAt = reader.GetDateTime(offset + 9);
            UpdatedAt = reader.GetDateTime(offset + 10);
        }

        public User(MySqlDataReader reader) : this(reader, 0) {}
    }
}
