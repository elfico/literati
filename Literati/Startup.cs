using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Literati.Startup))]
namespace Literati
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
