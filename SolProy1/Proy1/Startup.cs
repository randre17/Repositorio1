using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proy1.Startup))]
namespace Proy1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
