using MongoDB.Driver.Linq;
using MongoLibSys.Model.Base;

namespace MongoLibSys.Repository.Extensions
{
    internal static class BaseRepositoryExtension
    {
        public static IMongoQueryable<T> RemoveDeletedDocuments<T>(this IMongoQueryable<T> query) where T : BaseModel
        {
            return query.Where(x => x.DeletedAt == null);
        }

        public static IMongoQueryable<T> Paginate<T>(this IMongoQueryable<T> query, int page, int limit) where T : BaseModel
        {
            return query.Skip((page - 1) * limit).Take(limit);
        }
    }
}
