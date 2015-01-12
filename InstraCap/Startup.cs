using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InstraCap.Startup))]
namespace InstraCap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
