using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuanLyKyTucXa.Startup))]
namespace QuanLyKyTucXa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
