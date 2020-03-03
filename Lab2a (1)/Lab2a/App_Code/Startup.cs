using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab2a.Startup))]
namespace Lab2a
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
