using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommunityWebMVC.Startup))]
namespace CommunityWebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
