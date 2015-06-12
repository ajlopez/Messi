namespace Messi.Endpoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class LambdaOutputEndpoint
    {
        Action<object> action;

        public LambdaOutputEndpoint(Action<object> action)
        {
            this.action = action;
        }

        public void Send(object message)
        {
            this.action(message);
        }
    }
}
