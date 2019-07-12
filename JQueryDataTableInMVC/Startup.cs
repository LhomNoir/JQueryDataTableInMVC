using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JQueryDataTableInMVC.Startup))]
namespace JQueryDataTableInMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
