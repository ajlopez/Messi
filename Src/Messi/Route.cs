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
        Action<Message> action;

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

        public Route Process(Action<Message> action)
        {
            this.action = action;
            return this;
        }

        public void ProcessMessage()
        {
            Message message = this.input.NextMessage();

            if (this.action != null)
                this.action(message);

            if (this.output != null)
                this.output.Send(message);
        }
    }
}
