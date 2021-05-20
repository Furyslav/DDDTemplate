using System;
using System.Collections.Generic;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Projectname.CrossCuttingLayer.Pipeline.MediatR
{
    public static class AddMediatrPipelineExtensions
    {
        public static IServiceCollection AddMediatrPipeline(this IServiceCollection services, IEnumerable<Type> mediatrPipelines)
        {
            foreach (var mediatrPipeline in mediatrPipelines)
                services.TryAddEnumerable(ServiceDescriptor.Scoped(typeof(IPipelineBehavior<,>), mediatrPipeline));
           
            return services;
        }
    }
}