using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace projet_API
{
    public class Product
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
