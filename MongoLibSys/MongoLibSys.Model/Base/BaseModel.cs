using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoLibSys.Model.Base
{
    public class BaseModel
    {
        [BsonId()]
        public ObjectId Id { get; set; }
        [BsonElement("created_at")]
        [BsonRequired]        
        public BsonDateTime CreatedAt { get; set; }
        [BsonElement("deleted_at")]        
        public BsonDateTime DeletedAt { get; set; }

        public BaseModel()
        {
            this.CreatedAt = BsonDateTime.Create(DateTime.Now);            
        }
    }
}
