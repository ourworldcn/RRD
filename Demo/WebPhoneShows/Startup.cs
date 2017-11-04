using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPhoneShows.Startup))]
namespace WebPhoneShows
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
