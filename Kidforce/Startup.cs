using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kidforce.Startup))]
namespace Kidforce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
