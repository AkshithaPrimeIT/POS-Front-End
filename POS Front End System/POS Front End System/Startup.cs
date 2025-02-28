using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(POS_Front_End_System.Startup))]
namespace POS_Front_End_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
