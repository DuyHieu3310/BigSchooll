using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bigschooll.Startup))]
namespace Bigschooll
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
