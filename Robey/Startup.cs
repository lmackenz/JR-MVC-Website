using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Robey.Startup))]
namespace Robey
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
