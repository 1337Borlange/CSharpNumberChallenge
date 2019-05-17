using System;
using System.ComponentModel;
using NumberRetrievalHyperClient.App_Start;
using NumberRetrievalHyperClient.Providers;

namespace NumberRetrievalHyperClient
{
    public class AppLifetime : ILifetime
    {
        private readonly IConfigurationValuesProvider _configurationValueProvider;
        private readonly ICodeProvider _codeProvider;
        private readonly IRequestClientProvider _requestClientProvider;

        private string _resourceLocator;
        private string _requestedResource;

        public AppLifetime(IConfigurationValuesProvider configurationValueProvider, ICodeProvider codeProvider, IRequestClientProvider requestClientProvider)
        {
            _configurationValueProvider = configurationValueProvider;
            _codeProvider = codeProvider;
            _requestClientProvider = requestClientProvider;
        }

        public void OnRun()
        {
            var requestClient = _requestClientProvider.Construct(_codeProvider.PersonalCode);
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
