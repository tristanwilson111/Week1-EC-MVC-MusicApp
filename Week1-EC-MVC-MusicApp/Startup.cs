using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week1_EC_MVC_MusicApp.Startup))]
namespace Week1_EC_MVC_MusicApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
