using System.Web;
using Microsoft.Owin;

namespace Redbridge.Owin
{
    public class OwinContextProvider : IOwinContextProvider
    {
        public IOwinContext Current => HttpContext.Current?.GetOwinContext();
    }
}