using System;
using Microsoft.Extensions.Configuration;

namespace Helpers
{
    public static class ConfigurationHelper
    {
        private static IConfiguration _configuration;
        public static void Configure(IConfiguration configuration)
        {
            _configuration = configuration;
        }

		public static int MailPort => Convert.ToInt32(GetConfigValue("Smtp:Port"));
		public static string MailHost => GetConfigValue("Smtp:Host");
		public static string MailUsername => GetConfigValue("Smtp:Username");
		public static string MailPassword => GetConfigValue("Smtp:Password");

        public static string SendGridAPIKey => GetConfigValue("SendGridAPIKey");
        public static string GetConfigValue(string key)
        {
            string value = string.Empty;
            value = _configuration[key];
            return value;
        }

        public static IConfiguration GetConfiguration()
        {
            return _configuration;
        }
    }
}
