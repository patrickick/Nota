using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Revisao.Startup))]
namespace Revisao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
