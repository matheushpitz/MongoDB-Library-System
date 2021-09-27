using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoLibSys.Model.Data.Base;

namespace MongoLibSys.Model.Data
{
    public class BookUnit: BaseModel
    {
        [BsonElement("code")]
        [BsonRequired]
        public string Code { get; set; }
        [BsonElement("book_id")]
        [BsonRequired]
        public ObjectId BookId { get; set; }
        [BsonElement("is_available")]
        [BsonRequired]
        public bool IsAvailable { get; set; }
    }
}
