using System;
using NumberRetrievalHyperClient.Request;

namespace NumberRetrievalHyperClient.Providers
{
    public interface IRequestClientProvider
    {
        IRequestClient Construct(string gamerTag);
    }
}
