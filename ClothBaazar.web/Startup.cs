using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClothBaazar.web.Startup))]
namespace ClothBaazar.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
