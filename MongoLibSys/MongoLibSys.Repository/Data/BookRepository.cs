using MongoDB.Driver;
using MongoLibSys.Model;
using MongoLibSys.Repository.Contracts;
using MongoLibSys.Repository.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoLibSys.Repository.Data
{
    internal class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(MongoContext context) : base(context, "Books") { }
        public async Task<IEnumerable<Book>> GetAllPaginatedAsync(int limit, int page, string search = null)
        {
            var query = this._collection.AsQueryable()
                        .RemoveDeletedDocuments()
                        .Paginate(page, limit);

            return await query.ToListAsync();
        }
    }
}
