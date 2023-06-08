using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using ThaiTanic.Entities;

namespace ThaiTanic.State
{
    // TODO: Consider making this a singleton instead to lessen confusion
    internal class Cart
    {
        public List<CartEntry> Entries = new List<CartEntry>();
        public User User;

        public decimal TotalPrice
        {
            get
            {
                return Entries.Select(entry => entry.Item.Price * entry.Quantity).Sum();
            }
        }

        // TODO: Do validation such that no 'Item' in the entries have the same 'Id'
        // Adds an 'entry' if an 'entry.Item' in 'Entries' with the same 'Id' does not exist
        public void AddCartEntry(int itemId, int quantity)
        {
            if (quantity < 0)
            {
                // TODO: Should throw some exception
                return;
            }

            var existing = Entries.Where(entry => entry.Item.Id == itemId);
            
            if (existing.Any())
            {
                var item = existing.First();
                item.Quantity += quantity;
                return;
            }

            Entries.Add(new CartEntry()
            {
                Item = Items.GetItemById(itemId),
                Quantity = quantity
            });
        }

        // If you want to remove an entry altogether (not just decrease the quantity), you will need to enter a negative number
        // NOTE: SubtractCartEntry(2, 0) does NOTHING
        public void SubtractCartEntry(int itemId, int quantity)
        {
            var existing = Entries.Where(entry => entry.Item.Id == itemId);

            if (!existing.Any())
            {
                // TODO: Should throw some Exception
                return;
            }

            var item = existing.First();

            if (quantity < 0)
                item.Quantity = 0;
            else
                item.Quantity -= quantity;

            if (item.Quantity <= 0)
                Entries.Remove(Entries.Find(entry => entry.Item.Id == itemId));
        }

        public void Deserialize()
        {
            Entries.Clear();

            // TODO: Catch FileNotFoundException
            FileStream stream = File.OpenRead($"uid{User.Id}-localStorage.json");
            var serde = new DataContractJsonSerializer(Entries.GetType());

            Entries = (List<CartEntry>) serde.ReadObject(stream);
            stream.Close();
        }

        public void Serialize()
        {
            var serde = new DataContractJsonSerializer(Entries.GetType());
            var stream = File.Create($"uid{User.Id}-localStorage.json");

            serde.WriteObject(stream, Entries);
            stream.Close();
        }

        public void Clear()
        {
            File.Create($"uid{User.Id}-localStorage.json").Close();
            Entries.Clear();
        }

        // cart = new Cart(user)
        // cart.AddEntry(id, 10)
        // cart.SubtractEntry(id, 5) -> quantity = 5
        // cart.Sb(id, 6) -> Remove Entry
        // cart.Sb(id, -1) -> Remove
        // cart.Sb(id, 0) nothing

        public void AddEntriesToDGV(DataGridView dgv, int count = int.MaxValue, int offset = 0)
        {
            foreach (var entry in Entries.Skip(offset).Take(count))
            {
                dgv.Rows.Add(entry.Item.Id, entry.Item.Name, entry.Quantity, entry.TotalPrice);
            }
        }

        public Cart(User user)
        {
            User = user;
        }
    }

    [DataContract]
    public class CartEntry
    {
        [DataMember]
        public Items Item;

        [DataMember]
        public int Quantity;

        public decimal TotalPrice {
            get
            {
                return Quantity * Item.Price;
            }
        }
    }
}
