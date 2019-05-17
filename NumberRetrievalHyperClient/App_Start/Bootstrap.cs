using System;
using Autofac;
using NumberRetrievalHyperClient.Request;

namespace NumberRetrievalHyperClient.App_Start
{
    public class Bootstrap
    {
        private IContainer _container;

        public void Setup(Type lifeTimeType)
        {
            var builder = new ContainerBuilder();

            //Register components
            builder.RegisterType(lifeTimeType).As<ILifetime>().SingleInstance();
            builder.RegisterType<RequestClient>().AsImplementedInterfaces();

            //TODO: Add more registrations

            _container = builder.Build();
        }

        public void Run()
        {
            var lifetime = _container.Resolve<ILifetime>();

            lifetime.OnStartup();
            lifetime.OnRun();
            lifetime.OnShutdown();
        }
    }
}
