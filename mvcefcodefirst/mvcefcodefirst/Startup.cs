using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcefcodefirst.Startup))]
namespace mvcefcodefirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
