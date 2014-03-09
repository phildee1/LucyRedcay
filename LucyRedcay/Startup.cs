using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LucyRedcay.Startup))]
namespace LucyRedcay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
