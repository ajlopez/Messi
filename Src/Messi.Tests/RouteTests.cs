namespace Messi.Tests
{
    using System;
    using Messi.Endpoints;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RouteTests
    {
        [TestMethod]
        public void FromTo()
        {
            Message processed = null;

            Route route = new Route();

            route.From(new EnumerableInputEndpoint(new object[] { 42 }))
                .To(new LambdaOutputEndpoint(msg => { processed = msg; }));

            route.ProcessMessage();

            Assert.IsNotNull(processed);
            Assert.AreEqual(42, processed.Body);
        }

        [TestMethod]
        public void ProcessMessage()
        {
            Message processed = null;

            Route route = new Route();

            route.From(new EnumerableInputEndpoint(new object[] { 42 }))
                .Process(msg => { processed = msg; });

            route.ProcessMessage();

            Assert.IsNotNull(processed);
            Assert.AreEqual(42, processed.Body);
        }
    }
}
