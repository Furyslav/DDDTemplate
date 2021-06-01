using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Projectname.CrossCuttingLayer.Pipeline.MediatR
{
    public static class AddMediatrPipelineExtensions
    {
        public static IServiceCollection AddMediatrPipeline(this IServiceCollection services,
            IEnumerable<Type> mediatrPipelines)
        {
            foreach (var mediatrPipeline in mediatrPipelines)
            {
                // services.TryAddEnumerable(ServiceDescriptor.Scoped(typeof(IPipelineBehavior<,>), mediatrPipeline));
                // continue;
                var genericArguments = mediatrPipeline.GetGenericArguments();
                var genericWrapper =
                    typeof(Wrappers.MediatR.MediatrRequestWrapper<,>).MakeGenericType(genericArguments);
                var registerType = mediatrPipeline.MakeGenericType(genericWrapper, genericArguments.Last());

                var templateType = mediatrPipeline.GetInterfaces()
                    .First(t => t.GetGenericTypeDefinition() == typeof(IPipelineBehavior<,>));
                services.TryAddEnumerable(ServiceDescriptor.Scoped(templateType, registerType));
            }

            return services;
        }
    }
}