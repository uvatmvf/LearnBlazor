using Microsoft.Extensions.Hosting;
using MvcWebApp;

namespace SpecFlowProject.Hooks
{
    [Binding]
    public class EnvironmentSetupHooks
    {
        private static IHost? _host;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            var baseUrl = Environment.GetEnvironmentVariable("TEST_BASE_URL") ?? "http://localhost:5000";

            // If an instance is already listening at the base URL, skip starting a host here.
            try
            {
                using var http = new System.Net.Http.HttpClient();
                http.Timeout = TimeSpan.FromSeconds(2);
                var resp = http.GetAsync(baseUrl).GetAwaiter().GetResult();
                if (resp.IsSuccessStatusCode)
                {
                    return; // existing app is available
                }
            }
            catch
            {
                // Not available; continue to start local host
            }

            _host = Program.CreateHostBuilder(null)
                .UseContentRoot(Path.Combine(Environment.CurrentDirectory, "../../../../MvcWebApp"))
                .UseUrls(baseUrl)
                .Build();

            _host.Start();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            _host?.StopAsync().Wait();
        }
    }
}
