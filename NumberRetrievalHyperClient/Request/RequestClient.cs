using System;
using NumberRetrievalHyperClient.Transforms;

namespace NumberRetrievalHyperClient.Request
{
    public class RequestClient : IRequestClient
    {
        private readonly ITextTransform _transform;
        private readonly int _personalCode;

        public RequestClient(ITextTransform transform, int personalCode)
        {
            _transform = transform;
        }

        public string PerformRequest(string resourceLocator)
        {
            //TODO: Perform request, final resourceLocator after demessing is <locator>/personalCode

            throw new NotImplementedException();
        }
    }
}
