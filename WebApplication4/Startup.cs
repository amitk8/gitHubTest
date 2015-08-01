using Microsoft.Owin;
using Owin;
//dfjhsdjkhfsjkhfjksdhfjksdfh/sfsdfsd
//sdfsdfsdfsdfsdfsdfsdfsd/
//sdfsdfsdfsdfsdfsfsdfsd

[assembly: OwinStartupAttribute(typeof(WebApplication4.Startup))]
namespace WebApplication4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
