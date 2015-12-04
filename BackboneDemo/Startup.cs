using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BackboneDemo.Startup))]
namespace BackboneDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
