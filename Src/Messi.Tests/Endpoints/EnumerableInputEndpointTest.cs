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

            Assert.AreEqual("foo", endpoint.NextMessage());
            Assert.IsNull(endpoint.NextMessage());
        }

        [TestMethod]
        public void RunManyMessages()
        {
            EnumerableInputEndpoint endpoint = new EnumerableInputEndpoint(new object[] { "foo", "bar", "baz" });

            Assert.AreEqual("foo", endpoint.NextMessage());
            Assert.AreEqual("bar", endpoint.NextMessage());
            Assert.AreEqual("baz", endpoint.NextMessage());
            Assert.IsNull(endpoint.NextMessage());
        }
    }
}
