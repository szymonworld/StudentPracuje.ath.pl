using Microsoft.Owin;
using Owin;
using Pracuj.ath.bielsko.pl.App_Start;

[assembly: OwinStartupAttribute(typeof(Pracuj.ath.bielsko.pl.Startup))]
namespace Pracuj.ath.bielsko.pl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
