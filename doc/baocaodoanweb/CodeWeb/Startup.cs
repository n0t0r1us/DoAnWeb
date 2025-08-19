using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_61131562.Startup))]
namespace Web_61131562
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
