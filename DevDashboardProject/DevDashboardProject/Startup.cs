using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevDashboardProject.Startup))]
namespace DevDashboardProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
