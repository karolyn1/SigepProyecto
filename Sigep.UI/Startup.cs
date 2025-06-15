using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sigep.UI.Startup))]
namespace Sigep.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
