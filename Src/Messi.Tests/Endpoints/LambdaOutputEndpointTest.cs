namespace Messi.Tests.Endpoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Messi.Endpoints;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LambdaOutputEndpointTest
    {
        [TestMethod]
        public void SendMessage()
        {
            object message = "Foo";
            object processed = null;

            LambdaOutputEndpoint endpoint = new LambdaOutputEndpoint(obj => { processed = obj; });

            endpoint.Send(message);

            Assert.IsNotNull(processed);
            Assert.AreSame(message, processed);
        }
    }
}
