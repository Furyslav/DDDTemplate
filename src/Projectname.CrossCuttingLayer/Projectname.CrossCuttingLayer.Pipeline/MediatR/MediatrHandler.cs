using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Projectname.CrossCuttingLayer.Pipeline.MediatR
{
    public abstract class MediatrHandler<TRequest, TResponse> : IRequestHandler<MediatrRequestWrapper<TRequest, TResponse>, TResponse>
    {
        Task<TResponse> IRequestHandler<MediatrRequestWrapper<TRequest, TResponse>, TResponse>.Handle(
            MediatrRequestWrapper<TRequest, TResponse> requestWrapper,
            CancellationToken cancellationToken) => Handle(requestWrapper.Request, cancellationToken);
        
        public abstract Task<TResponse> Handle(TRequest request,
            CancellationToken cancellationToken);
    }
}