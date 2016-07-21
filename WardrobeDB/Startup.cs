using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WardrobeDB.Startup))]
namespace WardrobeDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
