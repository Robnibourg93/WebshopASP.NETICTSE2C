using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebshopSchool.Startup))]
namespace WebshopSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
