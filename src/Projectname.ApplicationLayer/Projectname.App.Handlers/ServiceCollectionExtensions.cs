using Microsoft.Extensions.DependencyInjection;

namespace Projectname.App.Handlers
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAppHandlers(this IServiceCollection services)
        {
            return services;
        }
    }
}