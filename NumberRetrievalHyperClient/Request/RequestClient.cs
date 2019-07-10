using System;
using NumberRetrievalHyperClient.Transforms;

namespace NumberRetrievalHyperClient.Request
{
    public class RequestClient : IRequestClient
    {
        private readonly ITextTransform _transform;
        private readonly string _gamerTag;

        public RequestClient(ITextTransform transform, string gamerTag)
        {
            _gamerTag = gamerTag;
        }

        public string PerformRequest(string resourceLocator)
        {
            //TODO: Perform request, final resourceLocator after demessing is <locator>/gamerTag

            throw new NotImplementedException();
        }
    }
}
