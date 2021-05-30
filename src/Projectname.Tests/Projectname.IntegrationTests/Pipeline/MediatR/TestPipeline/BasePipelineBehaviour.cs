using System;
using System.Threading;
using System.Threading.Tasks;
using Projectname.CrossCuttingLayer.Pipeline.MediatR;

namespace Projectname.IntegrationTests.Pipeline.MediatR.TestPipeline
{
    public sealed class BasePipelineBehaviour<TRequest, TResponse> : MediatrPipeline<TRequest, TResponse>
    {
        protected override async Task<TResponse> Handle(TRequest request, Func<Task<TResponse>> next, CancellationToken cancellationToken)
        {
            throw new BaseMediatrPipelineException();
        }
    }
}