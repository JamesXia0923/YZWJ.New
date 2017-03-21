using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YZWJ.New.Web.Startup))]
namespace YZWJ.New.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
