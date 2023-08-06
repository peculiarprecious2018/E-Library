using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_Library.Startup))]
namespace E_Library
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
