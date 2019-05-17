using System;
using NumberRetrievalHyperClient.App_Start;

namespace NumberRetrievalHyperClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var bootstrap = new Bootstrap();

            bootstrap.Setup(typeof(AppLifetime));
            bootstrap.Run();
        }
    }
}
