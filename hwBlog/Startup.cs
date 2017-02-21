using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hwBlog.Startup))]
namespace hwBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
