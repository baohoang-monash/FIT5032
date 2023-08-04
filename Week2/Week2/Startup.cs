using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week2.Startup))]
namespace Week2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
