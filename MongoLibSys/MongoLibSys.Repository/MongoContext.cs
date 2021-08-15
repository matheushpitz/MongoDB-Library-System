using MongoDB.Driver;
using MongoLibSys.Repository.Configurations;

namespace MongoLibSys.Repository
{
    public class MongoContext
    {
        private readonly MongoClient _client;
        private readonly MongoContextConfiguration _config;
        public MongoContext(MongoContextConfiguration config)
        {
            this._config = config;
            this._client = new MongoClient(this._config.ConnectionString);            
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return this._client.GetDatabase(this._config.Database).GetCollection<T>(collectionName);
        }
    }
}
