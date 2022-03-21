using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webteste.frmprincipal))]
namespace Webteste
{
    public partial class frmprincipal {


        public void Configuration(IAppBuilder app) {

            ConfigureAuth(app);


        }
        
    }
}
