namespace Messi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Messi.Endpoints;

    public class Route
    {
        IInputEndpoint input;
        IOutputEndpoint output;

        public Route From(IInputEndpoint endpoint)
        {
            this.input = endpoint;
            return this;
        }

        public Route To(IOutputEndpoint endpoint)
        {
            this.output = endpoint;
            return this;
        }

        public void ProcessMessage()
        {
            this.output.Send(this.input.NextMessage());
        }
    }
}
