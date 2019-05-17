using System;
namespace NumberRetrievalHyperClient.Providers
{
    public interface IConfigurationValuesProvider
    {
        string GetValue(string key);
    }
}
