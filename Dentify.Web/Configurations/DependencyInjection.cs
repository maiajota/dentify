using Dentify.Core.Settings;
using Dentify.Data.Context;

namespace Dentify.Web.Configurations;

public static class DependencyInjection
{
    public static void AddDependencies(this IServiceCollection services, AppSettings appSettings)
    {
        services.AddSingleton(appSettings);
        services.AddScoped<ApplicationDbContext>();
    }
}
