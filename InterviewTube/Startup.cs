using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InterviewTube.Startup))]
namespace InterviewTube
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
