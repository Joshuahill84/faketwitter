using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(faketwitter.Startup))]
namespace faketwitter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
