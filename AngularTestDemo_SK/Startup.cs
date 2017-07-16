using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularTestDemo_SK.Startup))]
namespace AngularTestDemo_SK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
