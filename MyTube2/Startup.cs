using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTube2.Startup))]
namespace MyTube2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
