using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proyectoWebII_empresa_asp.net.Startup))]
namespace proyectoWebII_empresa_asp.net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
