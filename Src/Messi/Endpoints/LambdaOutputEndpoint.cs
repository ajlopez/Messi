namespace Messi.Endpoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class LambdaOutputEndpoint : Messi.Endpoints.IOutputEndpoint
    {
        private Action<Message> action;

        public LambdaOutputEndpoint(Action<Message> action)
        {
            this.action = action;
        }

        public void Send(Message message)
        {
            this.action(message);
        }
    }
}
