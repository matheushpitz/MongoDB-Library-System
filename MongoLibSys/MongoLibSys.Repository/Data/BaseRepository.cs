using MongoDB.Driver;
using MongoLibSys.Model.Data.Base;
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
            foreach(var obj in objs)
            {
                obj.CreatedAt = DateTime.Now;
            }

            return this._collection.InsertManyAsync(objs);
        }

        public Task CreateOneAsync(T obj)
        {
            obj.CreatedAt = DateTime.Now;
            return this._collection.InsertOneAsync(obj);
        }

        public Task RemoveByIdAsync(T obj)
        {
            obj.DeletedAt = DateTime.Now;
            return this.ReplaceOneByIdAsync(obj);
        }

        public Task<ReplaceOneResult> ReplaceOneByIdAsync(T obj)
        {
            return this._collection.ReplaceOneAsync(x => x.Id.Equals(obj.Id), obj);
        }
    }
}
