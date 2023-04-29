using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using ThaiTanic.Entities;

namespace ThaiTanic.State
{
    // TODO: Consider making this a singleton instead to lessen confusion
    static internal class Cart
    {
        public static List<CartEntry> Entries = new List<CartEntry>();

        // TODO: Do validation such that no 'Item' in the entries have the same 'Id'
        // Adds an 'entry' if an 'entry.Item' in 'Entries' with the same 'Id' does not exist
        public static void AddCartEntry(int itemId, int quantity)
        {
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

        // If you want to remove an entry altogether (not just decrease the quantity), you will need to enter 0 or a negative number
        // NOTE: SubtractCartEntry(2, 0) does NOTHING
        public static void SubtractCartEntry(int itemId, int quantity)
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
            {
                Entries = Entries.Where(entry => entry.Item.Id != itemId).ToList();
            }
        }

        public static void Deserialize()
        {
            Entries = new List<CartEntry>();
            var stream = File.OpenRead("localStorage.json");
            var serde = new DataContractJsonSerializer(Entries.GetType());

            Entries = (List<CartEntry>) serde.ReadObject(stream);
            stream.Close();
        }

        public static void Serialize()
        {
            var serde = new DataContractJsonSerializer(Entries.GetType());
            var stream = File.Create("localStorage.json");

            serde.WriteObject(stream, Entries);
            stream.Close();
        }

        public static void Clear()
        {
            File.Create("localStorage.json").Close();
        }
    }

    [DataContract]
    class CartEntry
    {
        [DataMember]
        public Items Item;

        [DataMember]
        public int Quantity;
    }
}
