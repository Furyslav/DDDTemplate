using MediatR;

namespace Projectname.CrossCuttingLayer.Wrappers.MediatR
{
    public sealed class MediatrRequestWrapper<TRequest, TResult> : IRequest<TResult>
    {
        public MediatrRequestWrapper(TRequest request)
        {
            Request = request;
        }

        public TRequest Request { get; }
    }
}