using MongoDB.Bson;
using MongoLibSys.Model.Base;

namespace MongoLibSys.Model
{
    public class BookAuthor
    {
        public string Name { get; set; }
    }
    public class Book: BaseModel
    {
        public string Name { get; set; }
        public BookAuthor Author { get; set; }
        public BsonDateTime ReleasedAt { get; set; }
        public int InventoryNumber { get; set; }
    }
}
