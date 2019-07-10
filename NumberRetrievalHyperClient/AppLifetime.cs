using System;
using System.ComponentModel;
using NumberRetrievalHyperClient.App_Start;
using NumberRetrievalHyperClient.Providers;

namespace NumberRetrievalHyperClient
{
    public class AppLifetime : ILifetime
    {
        private readonly IConfigurationValuesProvider _configurationValueProvider;
        private readonly ITagProvider _tagProvider;
        private readonly IRequestClientProvider _requestClientProvider;

        private string _resourceLocator;
        private string _requestedResource;

        public AppLifetime(IConfigurationValuesProvider configurationValueProvider, ITagProvider tagProvider, IRequestClientProvider requestClientProvider)
        {
            _configurationValueProvider = configurationValueProvider;
            _tagProvider = tagProvider;
            _requestClientProvider = requestClientProvider;
        }

        public void OnRun()
        {
            var requestClient = _requestClientProvider.Construct(_tagProvider.GamerTag);
            _requestedResource = requestClient.PerformRequest(_resourceLocator);
        }

        public void OnShutdown()
        {
            Console.WriteLine($"Got value: {_requestedResource}");
        }

        public void OnStartup()
        {
            _resourceLocator = _configurationValueProvider.GetValue("resourceLocator");
        }
    }
}
