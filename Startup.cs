using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MattsBlog.Startup))]
namespace MattsBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
