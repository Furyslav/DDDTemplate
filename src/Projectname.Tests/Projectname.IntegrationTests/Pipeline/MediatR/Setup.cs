using System;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Projectname.App;
using Projectname.App.Pipeline;
using Projectname.CrossCuttingLayer.Pipeline.MediatR;
using Projectname.Infra;
using Projectname.IntegrationTests.Pipeline.MediatR.TestPipeline;

namespace Projectname.IntegrationTests.Pipeline.MediatR
{
    /*
    [SetUpFixture]
    public class Setup
    {
        private IServiceProvider _serviceProvider;
        
        [OneTimeSetUp]
        public void BeforeMediatrTestsRun()
        {
            var services = new ServiceCollection();
            services
                .AddApp()
                .AddInfra()
                ;
            
            _serviceProvider = services.BuildServiceProvider();
        }

        [OneTimeTearDown]
        public void AfterMediatrTestsRun()
        {
            _serviceProvider = null;
        }

        private void AddTestsServices(IServiceCollection services)
        {
            // services.AddMediatrPipeline(new[]
            // {
            //     typeof(TestPipelineBehaviour<,>)
            // });
        }
    }*/
}