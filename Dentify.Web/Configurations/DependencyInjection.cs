using Dentify.Core.Interfaces.Repositories;
using Dentify.Core.Settings;
using Dentify.Data.Context;
using Dentify.Data.Repositories;

namespace Dentify.Web.Configurations;

public static class DependencyInjection
{
    public static void AddDependencies(this IServiceCollection services, AppSettings appSettings)
    {
        services.AddSingleton(appSettings);
        services.AddScoped<ApplicationDbContext>();

        AddRepositories(services);
    }

    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();
    }
}
