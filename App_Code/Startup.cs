using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Babystore.Startup))]
namespace Babystore
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
