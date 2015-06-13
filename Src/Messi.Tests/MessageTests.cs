namespace Messi.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MessageTests
    {
        [TestMethod]
        public void GetBody()
        {
            Message message = new Message("Foo");

            Assert.AreEqual("Foo", message.Body);
        }

        [TestMethod]
        public void GetUnknownHeader()
        {
            Message message = new Message(null);

            Assert.IsNull(message.Headers["Foo"]);
        }

        [TestMethod]
        public void SetGetHeader()
        {
            Message message = new Message(null);

            message.Headers["Foo"] = "Bar";

            Assert.AreEqual("Bar", message.Headers["Foo"]);
        }

        [TestMethod]
        public void CloneHeaders()
        {
            Message message = new Message(null);
            message.Headers["Foo"] = "Bar";

            Message message2 = new Message(null, message.Headers);
            message2.Headers["Foo"] = "Baz";
            message2.Headers["Answer"] = 42;

            Assert.AreEqual("Bar", message.Headers["Foo"]);
            Assert.IsNull(message.Headers["Answer"]);
            Assert.AreEqual("Baz", message2.Headers["Foo"]);
            Assert.AreEqual(42, message2.Headers["Answer"]);
        }
    }
}
