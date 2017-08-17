using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewChatter.Startup))]
namespace NewChatter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
