namespace Messi.Endpoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class EnumerableInputEndpoint
    {
        private IEnumerator<object> enumerator;

        public EnumerableInputEndpoint(IEnumerable<object> elements)
        {
            this.enumerator = elements.GetEnumerator();
        }

        public object NextMessage()
        {
            if (!this.enumerator.MoveNext())
                return null;

            return this.enumerator.Current;
        }
    }
}
