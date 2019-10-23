using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevDashboard.Startup))]
namespace DevDashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
