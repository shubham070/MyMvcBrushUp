using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMvcBrushUp.Startup))]
namespace MyMvcBrushUp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
