using MySql.Data.MySqlClient;

namespace ThaiTanic.Entities
{
    internal class OrderBatch
    {
        public int Id;
        public Items AssociatedItem;
        public int Quantity;

        public OrderBatch(MySqlDataReader reader, int offset)
        {
            Id = reader.GetFieldValue<int>(offset);
            Quantity = reader.GetFieldValue<int>(offset + 1);
            AssociatedItem = Items.GetItemById(reader.GetFieldValue<int>(3));
        }

        public OrderBatch(MySqlDataReader reader) : this(reader, 0) {}

        public OrderBatch(MySqlDataReader reader, Items associatedItem, int offset)
        {
            Id = reader.GetFieldValue<int>(offset);
            Quantity = reader.GetFieldValue<int>(offset + 1);
            AssociatedItem = associatedItem;
        }

        public OrderBatch(MySqlDataReader reader, Items associatedItem) : this(reader, associatedItem, 0) {}
    }
}
