using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShinsyuKensaku.Startup))]
namespace ShinsyuKensaku
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
