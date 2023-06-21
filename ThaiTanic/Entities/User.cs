﻿using Guna.UI2.WinForms.Suite;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

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

        public void UpdateRole(UserRole role, string username, string password)
        {
            var user = AuthUser(username, password);

            if (user == null || user.Role != UserRole.Admin)
            {
                // TODO: 
                return;
            }

            string sql = "UPDATE user SET role_enum = @role WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@role", role.ToString());
                cmd.Parameters.AddWithValue("@id", Id);

                cmd.ExecuteNonQuery();
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

        public void UpdatePassword(string oldPass, string newPass)
        {
            string sql = "UPDATE user SET password = MD5(@password) WHERE id = @id";

            if (AuthUser(Username, oldPass) == null)
            {
                throw new Exception("Wrong Password");
            }

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@password", newPass);
                cmd.Parameters.AddWithValue("@id", Id);

                cmd.ExecuteNonQuery();
            }
        }

        public void Fetch()
        {
            string sql = "SELECT id, username, first_name, last_name, middle_name, phone_number, birthday, email, role_enum, created_at, updated_at FROM user WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@id", Id);

                var reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    // TODO: Handle error when item is already deleted from database
                    return;
                }

                var user = new User(reader);

                Username = user.Username;
                FirstName = user.FirstName;
                MiddleName = user.MiddleName;
                LastName = user.LastName;
                PhoneNumber = user.PhoneNumber;
                Email = user.Email;
                Birthday = user.Birthday;
                CreatedAt = user.CreatedAt;
                UpdatedAt = user.UpdatedAt;
            }
        }


        public void Update(string username, string firstName, string middleName, string lastName, string email, string phoneNumber, DateTime birthday)
        {
            string sql = @"UPDATE user SET username = @username, first_name = @first_name, middle_name = @middle_name, last_name = @last_name, email = @email, 
                    phone_number = @phone_number, birthday = @birthday WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@first_name", firstName);
                cmd.Parameters.AddWithValue("@middle_name", middleName);
                cmd.Parameters.AddWithValue("@last_name", lastName);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone_number", phoneNumber);
                cmd.Parameters.AddWithValue("@birthday", birthday);
                cmd.Parameters.AddWithValue("@id", Id);

                cmd.ExecuteNonQuery();
            }

            Fetch();
        }

        public static List<User> GetAllUsers()
        {
            string sql = @"SELECT id, username, first_name, last_name, middle_name, phone_number, birthday, email, role_enum, created_at, updated_at FROM user";

            using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                conn.Open();

                var result = new List<User>();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                    result.Add(new User(reader));

                return result;
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

        public override string ToString()
        {
            return $"#{Id} - {FullName}";
        }
    }
}
