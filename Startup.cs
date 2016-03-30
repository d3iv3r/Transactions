using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(appTransacciones.Startup))]
namespace appTransacciones
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
