using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureBootCamp1.Startup))]
namespace AzureBootCamp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
