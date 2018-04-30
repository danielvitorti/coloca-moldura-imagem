using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(upload_imagem.Startup))]
namespace upload_imagem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
