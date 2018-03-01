using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GIEX.Startup))]
namespace GIEX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
