using Microsoft.Extensions.DependencyInjection;
using MongoLibSys.Repository.Configurations;
using System;

namespace MongoLibSys.Repository.Extensions
{
    public static class MongoContextExtension
    {
        public static void AddMongoDB(this IServiceCollection services, Action<MongoContextConfiguration> config)
        {
            MongoContextConfiguration configuration = new MongoContextConfiguration();
            config(configuration);

            MongoContext context = new MongoContext(configuration);
            services.AddSingleton<MongoContext>(context);
        }
    }
}
