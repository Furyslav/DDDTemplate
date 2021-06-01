using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Projectname.CrossCuttingLayer.Pipeline.MediatR
{
    public abstract class MediatrPipeline<TRequest, TResponse> : IPipelineBehavior<MediatrRequestWrapper<TRequest, TResponse>, TResponse>
    {
        public Task<TResponse> Handle(
            MediatrRequestWrapper<TRequest, TResponse> requestWrapper,
            CancellationToken cancellationToken,
            RequestHandlerDelegate<TResponse> next)
            => Handle(requestWrapper.Request, async () => await next(), cancellationToken);

        protected abstract Task<TResponse> Handle(TRequest request, Func<Task<TResponse>> next,
            CancellationToken cancellationToken);
    }
    
   
}