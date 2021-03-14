using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Max_Zimmer.Startup1))]

namespace Max_Zimmer
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
