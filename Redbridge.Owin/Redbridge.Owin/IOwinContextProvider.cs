using Microsoft.Owin;

namespace Redbridge.Owin
{
    public interface IOwinContextProvider
    {
        IOwinContext Current { get; }
    }
}