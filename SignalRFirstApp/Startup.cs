using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRFirstApp.Startup))]
namespace SignalRFirstApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
