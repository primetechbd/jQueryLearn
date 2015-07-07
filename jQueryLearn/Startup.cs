using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jQueryLearn.Startup))]
namespace jQueryLearn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
