using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTO
{
    public class ConfigurationDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public string Host { get; set; }
        public string LogoPath { get; set; }
    }
}
