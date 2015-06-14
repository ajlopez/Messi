namespace Messi.Endpoints
{
    using System;

    public interface IOutputEndpoint
    {
        void Send(Messi.Message message);
    }
}
