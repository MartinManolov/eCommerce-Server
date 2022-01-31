namespace eCommerceServer.Infrastructure
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class ConfigurationExtensions
    {
        public static AppSettings GetApplicationSettings(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var applicationSettingsConfiguration = configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(configuration.GetSection("AppSettings"));
            
            return applicationSettingsConfiguration.Get<AppSettings>();
        }
    }
}
