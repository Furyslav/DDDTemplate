using Microsoft.Extensions.DependencyInjection;
using Projectname.CrossCuttingLayer.Pipeline.MediatR;

namespace Projectname.App.Pipeline
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPipeline(this IServiceCollection services)
        {
            services.AddMediatrPipeline(new[]
            {
                typeof(ValidationPipeline<,>)
            });
            
            return services;
        }
    }
}