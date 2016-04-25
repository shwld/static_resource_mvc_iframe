using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StaticFile.Startup))]
namespace StaticFile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
