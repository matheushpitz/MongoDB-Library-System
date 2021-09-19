using MongoLibSys.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoLibSys.Repository.Contracts
{
    public interface IBookRepository: IBaseRepository<Book>
    {
        Task<IEnumerable<Book>> GetAllPaginatedAsync(int limit, int page, string search = null);
    }
}
