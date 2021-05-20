using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Projectname.CrossCuttingLayer.Wrappers.MediatR;

namespace Projectname.CrossCuttingLayer.Pipeline.MediatR
{
    public static class MediatrExtensions
    {
        public static Task<TResult> SendRequest<TRequest, TResult>(this IMediator mediator, TRequest request,
            CancellationToken cancellationToken)
            => mediator.Send(new MediatrRequestWrapper<TRequest, TResult>(request), cancellationToken);
    }
}