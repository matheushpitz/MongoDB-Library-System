using MongoDB.Bson;
using MongoDB.Driver;
using MongoLibSys.Model.Base;
using MongoLibSys.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoLibSys.Repository.Data
{
    internal class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        protected readonly IMongoCollection<T> _collection;
        public BaseRepository(MongoContext context, string collectionName)
        {
            this._collection = context.GetCollection<T>(collectionName);
        }
        public Task CreateManyAsync(IEnumerable<T> objs)
        {
            return this._collection.InsertManyAsync(objs);
        }

        public Task CreateOneAsync(T obj)
        {
            return this._collection.InsertOneAsync(obj);
        }

        public Task<DeleteResult> RemoveByIdAsync(ObjectId id)
        {
            return this._collection.DeleteOneAsync<T>(x => x.Id.Equals(id));
        }

        public Task<ReplaceOneResult> ReplaceOneByIdAsync(T obj)
        {
            return this._collection.ReplaceOneAsync(x => x.Id.Equals(obj.Id), obj);
        }
    }
}
