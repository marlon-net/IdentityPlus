using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityPlus.Startup))]
namespace IdentityPlus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
