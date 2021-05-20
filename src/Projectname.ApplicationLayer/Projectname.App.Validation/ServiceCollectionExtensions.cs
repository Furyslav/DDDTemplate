using Microsoft.Extensions.DependencyInjection;

namespace Projectname.App.Validation
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAppValidation(this IServiceCollection services)
        {
            return services;
        }
    }
}