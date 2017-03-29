using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YZWJ.Web.New.MVC.Startup))]
namespace YZWJ.Web.New.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
