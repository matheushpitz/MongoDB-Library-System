using Microsoft.Extensions.DependencyInjection;
using MongoLibSys.Repository.Contracts;
using MongoLibSys.Repository.Data;

namespace MongoLibSys.Repository.Extensions
{
    public static class RepositoryExtension
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}
