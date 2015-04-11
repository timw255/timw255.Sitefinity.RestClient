using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class LayoutControlDataPermissions
    {
        public string ControlDataID { get; set; }
        public bool DropOn { get; set; }
        public bool View { get; set; }
        public bool Move { get; set; }
        public bool EditProperties { get; set; }
        public bool Delete { get; set; }
        public bool ChangeOwner { get; set; }
        public bool ChangePermissions { get; set; }

        public LayoutControlDataPermissions() { }
    }
}
