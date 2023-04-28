using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using ThaiTanic.Entities;

namespace ThaiTanic.State
{
    // TODO: Consider making this a singleton instead to lessen confusion
    static internal class Cart
    {
        public static List<CartEntry> Items = new List<CartEntry>();

        public static void Deserialize()
        {
            Items = new List<CartEntry>();
            var stream = File.OpenRead("localStorage.json");
            var serde = new DataContractJsonSerializer(Items.GetType());

            Items = (List<CartEntry>) serde.ReadObject(stream);
            stream.Close();
        }

        public static void Serialize()
        {
            var serde = new DataContractJsonSerializer(Items.GetType());
            var stream = File.Create("localStorage.json");

            serde.WriteObject(stream, Items);
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
