using Microsoft.Extensions.DependencyInjection;
using Projectname.App.Access;
using Projectname.App.Handlers;
using Projectname.App.Pipeline;
using Projectname.App.Validation;

namespace Projectname.App
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApp(this IServiceCollection services)
        {
            services
                .AddPipeline()
                .AddAppAccess()
                .AddAppHandlers()
                .AddAppValidation()
                ;
                
            
            return services;
        }
    }
}