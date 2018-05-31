using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NSGitHubDemo.Startup))]
namespace NSGitHubDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
