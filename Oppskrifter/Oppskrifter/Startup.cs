using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Oppskrifter.Startup))]
namespace Oppskrifter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
