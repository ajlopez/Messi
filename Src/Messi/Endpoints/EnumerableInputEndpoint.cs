namespace Messi.Endpoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class EnumerableInputEndpoint : Messi.Endpoints.IInputEndpoint
    {
        private IEnumerator<object> enumerator;

        public EnumerableInputEndpoint(IEnumerable<object> elements)
        {
            this.enumerator = elements.GetEnumerator();
        }

        public Message NextMessage()
        {
            if (!this.enumerator.MoveNext())
                return null;

            return new Message(this.enumerator.Current);
        }
    }
}
