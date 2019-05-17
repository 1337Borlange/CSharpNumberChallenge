using System;
using System.ComponentModel;

namespace NumberRetrievalHyperClient.App_Start
{
    public interface ILifetime
    {
        void OnStartup();
        void OnRun();
        void OnShutdown();
    }
}
