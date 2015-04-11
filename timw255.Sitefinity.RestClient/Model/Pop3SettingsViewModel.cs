using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class Pop3SettingsViewModel
    {
        public string Host { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public bool UseSSL { get; set; }

        public Pop3SettingsViewModel() { }
    }
}
