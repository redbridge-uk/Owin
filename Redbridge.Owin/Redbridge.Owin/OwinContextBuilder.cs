using System.Collections.Generic;
using Microsoft.Owin;

namespace Redbridge.Owin
{
    public class OwinContextBuilder : IOwinContextProvider
    {
        public OwinContextBuilder()
        {
            var environment = new Dictionary<string, object>();
            Current = new OwinContext(environment);
        }

        public IOwinContext Current { get; }
    }
}
