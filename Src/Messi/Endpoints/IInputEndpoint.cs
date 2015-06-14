namespace Messi.Endpoints
{
    using System;

    public interface IInputEndpoint
    {
        Messi.Message NextMessage();
    }
}
