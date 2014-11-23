using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodOrderSystem.Web.Startup))]
namespace FoodOrderSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
