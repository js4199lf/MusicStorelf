using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(M1.Startup))]
namespace M1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
