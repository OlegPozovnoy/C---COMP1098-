using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNETCOMP2084.Startup))]
namespace ASPNETCOMP2084
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
