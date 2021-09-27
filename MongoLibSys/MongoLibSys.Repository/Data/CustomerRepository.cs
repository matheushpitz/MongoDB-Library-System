using MongoLibSys.Model;
using MongoLibSys.Repository.Contracts;

namespace MongoLibSys.Repository.Data
{
    internal class CustomerRepository: BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(MongoContext context) : base(context, "Customers") { }
    }
}
