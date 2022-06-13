using Microsoft.Extensions.Hosting;
using MvcWebApp;

namespace SpecFlowProject.Hooks
{
    [Binding]
    public class EnvironmentSetupHooks
    {
        private static IHost _host;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            _host = Program.CreateHostBuilder(null).UseContentRoot(Path.Combine(Environment.CurrentDirectory, "../../../../MvcWebApp")).Build();

            _host.Start();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            _host.StopAsync().Wait();
        }
    }
}
