using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoLibSys.Core.Configurations;

namespace MongoLibSys.Core.Extensions
{
    public static class ConfigurationExtension
    {
        public static void AddConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            MainConfig config = new MainConfig();
            configuration.Bind(config);

            services.AddSingleton<MainConfig>(config);
        }
    }
}
