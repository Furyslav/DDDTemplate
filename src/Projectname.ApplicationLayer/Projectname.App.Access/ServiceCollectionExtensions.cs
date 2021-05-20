using Microsoft.Extensions.DependencyInjection;

namespace Projectname.App.Access
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAppAccess(this IServiceCollection services)
        {
            return services;
        }
    }
}