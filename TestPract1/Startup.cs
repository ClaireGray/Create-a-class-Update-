using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestPract1.Startup))]
namespace TestPract1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
