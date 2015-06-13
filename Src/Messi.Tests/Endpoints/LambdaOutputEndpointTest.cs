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
            object body = "Foo";
            Message processed = null;

            LambdaOutputEndpoint endpoint = new LambdaOutputEndpoint(msg => { processed = msg; });

            endpoint.Send(new Message("Foo"));

            Assert.IsNotNull(processed);
            Assert.AreSame(body, processed.Body);
        }
    }
}
