using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Projectname.CrossCuttingLayer.Pipeline.MediatR;

namespace Projectname.IntegrationTests.Pipeline.MediatR.TestPipeline
{
    public sealed class BaseQueyHandler : MediatrHandler<BasePipelineQuey, Unit>
    {
        public override Task<Unit> Handle(BasePipelineQuey request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}