using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Owin;
using Owin;
using PartsUnlimited;
using System.Web.Configuration;

[assembly: OwinStartup(typeof(Startup))]

//comment
namespace PartsUnlimited
{
	// bellevue comment!!
	// second commit
	// some other change
    // change in common2
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
			// fl discount changes
            ConfigureAuth(app);

            TelemetryConfiguration.Active.InstrumentationKey = WebConfigurationManager.AppSettings["APPINSIGHTS_INSTRUMENTATIONKEY"];

        }
    }
}
