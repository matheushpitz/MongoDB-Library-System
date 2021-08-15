using MongoDB.Bson;
using MongoDB.Driver;
using MongoLibSys.Model.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoLibSys.Repository.Contracts
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        Task CreateOneAsync(T obj);
        Task CreateManyAsync(IEnumerable<T> objs);
        Task<DeleteResult> RemoveByIdAsync(ObjectId id);
        Task<ReplaceOneResult> ReplaceOneByIdAsync(T obj);
    }
}
