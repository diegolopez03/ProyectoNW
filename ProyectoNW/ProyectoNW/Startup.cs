using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoNW.Startup))]
namespace ProyectoNW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
