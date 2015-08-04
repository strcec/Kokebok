using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kokebok.Startup))]
namespace Kokebok
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
