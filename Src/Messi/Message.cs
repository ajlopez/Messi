namespace Messi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Message
    {
        private MessageHeaders headers = new MessageHeaders();
        private object body;

        public Message(object body)
        {
            this.body = body;
            this.headers = new MessageHeaders();
        }

        public Message(object payload, MessageHeaders headers)
        {
            this.body = body;
            this.headers = headers.Clone();
        }

        public object Body { get { return this.body; } }

        public MessageHeaders Headers { get { return this.headers; } }

        public class MessageHeaders
        {
            private IDictionary<string, object> values = new Dictionary<string, object>();

            public object this[string name]
            {
                get
                {
                    if (this.values.ContainsKey(name))
                        return this.values[name];

                    return null;
                }

                set
                {
                    this.values[name] = value;
                }
            }

            internal MessageHeaders Clone()
            {
                MessageHeaders headers = new MessageHeaders();

                foreach (var key in this.values.Keys)
                    headers.values[key] = this.values[key];

                return headers;
            }
        }
    }
}
