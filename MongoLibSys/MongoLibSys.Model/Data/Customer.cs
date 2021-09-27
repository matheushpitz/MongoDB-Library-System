using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoLibSys.Model.Data.Base;

namespace MongoLibSys.Model.Data
{
    public class CustomerAddress
    {
        [BsonElement("street")]
        public string Street { get; set; }
        [BsonElement("number")]
        public string Number { get; set; }
        [BsonElement("postal_code")]
        public string PostalCode { get; set; }
        [BsonElement("city")]
        public string City { get; set; }
        [BsonElement("state")]
        public string State { get; set; }
        [BsonElement("country")]
        public string Country { get; set; }
    }
    public class Customer : BaseModel
    {
        [BsonElement("name")]
        [BsonRequired]
        public string Name { get; set; }
        [BsonElement("email")]
        [BsonRequired]
        public string Email { get; set; }
        [BsonElement("birth_date")]
        [BsonRequired]
        public BsonDateTime BirthDate { get; set; }
        [BsonElement("address")]
        public CustomerAddress Address { get; set; }
    }
}
