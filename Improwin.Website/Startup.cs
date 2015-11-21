using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Improwin.Website.Startup))]
namespace Improwin.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
