using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Projectname.CrossCuttingLayer.Pipeline.MediatR;
using Projectname.CrossCuttingLayer.Wrappers.FluentValidation;

namespace Projectname.App.Pipeline
{
    public sealed class ValidationPipeline<TRequest, TResponse> : MediatrPipeline<TRequest, TResponse>
    {
        private readonly IEnumerable<IFluentValidator<TRequest>> _validators;

        public ValidationPipeline(IEnumerable<IFluentValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        protected override async Task<TResponse> Handle(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken)
        {
            foreach (var validator in _validators)
            {
                var validateResult = await validator.ValidateAsync(request, cancellationToken);
                if (!validateResult.IsValid)
                    throw new Exception();
            }
            
            return await next();
        }
    }
}