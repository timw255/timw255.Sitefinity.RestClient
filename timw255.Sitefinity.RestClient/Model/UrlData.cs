using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public abstract class UrlData
    {
        public string ApplicationName { get; set; }
        public int Culture { get; set; }
        public bool Disabled { get; set; }
        public bool IsDefault { get; set; }
        public bool RedirectToDefault { get; set; }
        public string Url { get; set; }

        public UrlData() { }
    }
}
