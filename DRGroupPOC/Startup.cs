using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DRGroupPOC.Startup))]
namespace DRGroupPOC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
