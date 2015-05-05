using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class PageTemplateDraftVersionInfo
    {
        public bool IsContentEditable { get; set; }
        public bool IsEditable { get; set; }
        public bool IsLocked { get; set; }
        public bool IsLockedByCurrentUser { get; set; }
        public string LockedByUser { get; set; }
        public string PageTitle { get; set; }
        public WcfChange VersionInfo { get; set; }

        public PageTemplateDraftVersionInfo() { }
    }
}
