using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DavaoCarRentalHub.Startup))]
namespace DavaoCarRentalHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
