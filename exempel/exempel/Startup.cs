using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(exempel.Startup))]
namespace exempel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
