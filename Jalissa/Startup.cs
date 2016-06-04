using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jalissa.Startup))]
namespace Jalissa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
