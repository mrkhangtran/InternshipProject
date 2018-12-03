using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InterProject.Startup))]
namespace InterProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
