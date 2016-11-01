using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_WebForms.Startup))]
namespace Test_WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
