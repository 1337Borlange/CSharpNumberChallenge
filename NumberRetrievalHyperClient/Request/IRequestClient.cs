using System;
namespace NumberRetrievalHyperClient.Request
{
    public interface IRequestClient
    {
        string PerformRequest(string resourceLocator);
    }
}
