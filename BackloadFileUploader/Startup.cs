using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BackloadFileUploader.Startup))]
namespace BackloadFileUploader
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
