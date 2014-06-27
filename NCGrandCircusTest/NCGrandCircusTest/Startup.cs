using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NCGrandCircusTest.Startup))]
namespace NCGrandCircusTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
