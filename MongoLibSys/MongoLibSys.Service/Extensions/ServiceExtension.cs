using Microsoft.Extensions.DependencyInjection;
using MongoLibSys.Service.Contracts;
using MongoLibSys.Service.Data;

namespace MongoLibSys.Service.Extensions
{
    public static class ServiceExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
        }
    }
}
