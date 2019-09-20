using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(goldberg_MIS4200.Startup))]
namespace goldberg_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
