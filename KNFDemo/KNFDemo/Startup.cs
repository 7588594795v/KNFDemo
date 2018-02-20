using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KNFDemo.Startup))]
namespace KNFDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
