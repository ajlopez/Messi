namespace Messi.Tests.Endpoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Messi.Endpoints;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EnumerableInputEndpointTest
    {
        [TestMethod]
        public void RunNoMessage()
        {
            EnumerableInputEndpoint endpoint = new EnumerableInputEndpoint(new object[] { });

            Assert.IsNull(endpoint.NextMessage());
        }

        [TestMethod]
        public void RunOneMessage()
        {
            EnumerableInputEndpoint endpoint = new EnumerableInputEndpoint(new object[] { "foo" });

            var result = endpoint.NextMessage();

            Assert.IsNotNull(result);
            Assert.AreEqual("foo", result.Body);

            Assert.IsNull(endpoint.NextMessage());
        }

        [TestMethod]
        public void RunManyMessages()
        {
            EnumerableInputEndpoint endpoint = new EnumerableInputEndpoint(new object[] { "foo", "bar", "baz" });

            var result = endpoint.NextMessage();

            Assert.IsNotNull(result);
            Assert.AreEqual("foo", result.Body);

            result = endpoint.NextMessage();

            Assert.IsNotNull(result);
            Assert.AreEqual("bar", result.Body);

            result = endpoint.NextMessage();

            Assert.IsNotNull(result);
            Assert.AreEqual("baz", result.Body);

            Assert.IsNull(endpoint.NextMessage());
        }
    }
}
