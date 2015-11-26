using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projectl3rainst0rm.Startup))]
namespace Projectl3rainst0rm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
