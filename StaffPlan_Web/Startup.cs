using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StaffPlan_Web.Startup))]
namespace StaffPlan_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
