﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ThaiTanic.Entities
{
    enum ItemCategory
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

    [DataContract]
    internal class Items
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
        public DateTime CreatedAt;

        [DataMember]
        public DateTime UpdatedAt;

        // Syncs object with corresponding table record
        public void Fetch()
        {
            string sql = "SELECT id, name, description, price, category, created_at, updated_at FROM items WHERE id = @id";

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
        public static bool CreateItem(string name, string description, decimal price, ItemCategory category, string username, string password)
        {
            string sql = "INSERT INTO items (name, description, price, category) VALUES (@name, @description, @price, @category)";

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

                cmd.ExecuteNonQuery();

                // TODO: Handle Errors
            }

            return true;
        }

        public static List<Items> GetAllItems()
        {
            string sql = "SELECT id, name, description, price, category, created_at, updated_at FROM items";

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
            string sql = "SELECT id, name, description, price, category, created_at, updated_at FROM items WHERE id = @id";

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
        }

        public Items(MySqlDataReader reader): this(reader, 0) {}
    }
}
