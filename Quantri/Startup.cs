using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quantri.Startup))]
namespace Quantri
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
