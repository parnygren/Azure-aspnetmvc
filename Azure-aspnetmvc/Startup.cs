using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Azure_aspnetmvc.Startup))]
namespace Azure_aspnetmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
