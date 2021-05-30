using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Projectname.CrossCuttingLayer.Pipeline.MediatR;


namespace Projectname.IntegrationTests.Pipeline.MediatR.TestPipeline
{
    [TestFixture]
    public sealed class TestPipelineBehaviour
    {
        private IServiceProvider _serviceProvider;
        
        [OneTimeSetUp]
        public void BeforeMediatrTestsRun()
        {
            var services = new ServiceCollection();
            services
                .AddMediatR(typeof(TestPipelineBehaviour))
                
                .AddMediatrPipeline(new []
                {
                    typeof(BasePipelineBehaviour<,>)
                })
                ;
            
            _serviceProvider = services.BuildServiceProvider();
        }

        [OneTimeTearDown]
        public void AfterMediatrTestsRun()
        {
            _serviceProvider = null;
        }

        [Test]
        public async Task CheckPipepineIsWorkByThrowException()
        {
            var mediatr = _serviceProvider.GetService<IMediator>();
           // var c = _serviceProvider.GetServices(typeof(IPipelineBehavior<BasePipelineQuey,Unit>));

            Assert.ThrowsAsync<BaseMediatrPipelineException>(
                async () => await mediatr.SendRequest<BasePipelineQuey, Unit>(new BasePipelineQuey(),
                    CancellationToken.None));
            
            /*
             * Expected: <Projectname.IntegrationTests.Pipeline.MediatR.TestPipeline.BaseMediatrPipelineException>
  But was:  <System.ArgumentException: Implementation type 'Projectname.IntegrationTests.Pipeline.MediatR.TestPipeline.BasePipelineBehaviour`2[Projectname.CrossCuttingLayer.Pipeline.MediatR.MediatrRequestWrapper`2[Projectname.IntegrationTests.Pipeline.MediatR.TestPipeline.BasePipelineQuey,MediatR.Unit],MediatR.Unit]' can't be converted to service type 'MediatR.IPipelineBehavior`2[Projectname.CrossCuttingLayer.Pipeline.MediatR.MediatrRequestWrapper`2[Projectname.IntegrationTests.Pipeline.MediatR.TestPipeline.BasePipelineQuey,MediatR.Unit],MediatR.Unit]'
             */
        }
    }
}