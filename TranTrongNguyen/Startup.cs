using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranTrongNguyen.Startup))]
namespace TranTrongNguyen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
