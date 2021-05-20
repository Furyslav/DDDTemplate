using MediatR;

namespace Projectname.CrossCuttingLayer.Pipeline.MediatR
{
    public class MediatrRequestWrapper<TRequest, TResult> : IRequest<TResult>
    {
        public MediatrRequestWrapper(TRequest request)
        {
            Request = request;
        }

        public TRequest Request { get; }
    }
}