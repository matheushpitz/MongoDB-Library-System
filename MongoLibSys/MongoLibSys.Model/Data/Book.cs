using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoLibSys.Model.Data.Base;

namespace MongoLibSys.Model.Data
{
    public class BookAuthor
    {
        [BsonElement("name")]
        [BsonRequired]
        public string Name { get; set; }
    }
    public class Book: BaseModel
    {
        [BsonElement("name")]
        [BsonRequired]
        public string Name { get; set; }
        [BsonElement("author")]
        [BsonRequired]
        public BookAuthor Author { get; set; }
        [BsonElement("released_at")]
        [BsonRequired]
        public BsonDateTime ReleasedAt { get; set; }
    }
}
