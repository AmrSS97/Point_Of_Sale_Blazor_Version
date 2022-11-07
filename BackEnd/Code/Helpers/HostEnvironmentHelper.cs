using Microsoft.Extensions.Hosting;

namespace Notifications.Helpers
{
    public class HostEnvironmentHelper
    {
        public static IHostEnvironment HostingEnvironment { get; private set; }

        public static void Configure(IHostEnvironment hostingEnvironment)
        {
            HostingEnvironment = hostingEnvironment;
        }
    }
}
