using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSiteDocTruyen.Startup))]
namespace WebSiteDocTruyen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
