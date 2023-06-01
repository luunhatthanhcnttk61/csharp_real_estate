using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(csharp_real_estate.Startup))]
namespace csharp_real_estate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
