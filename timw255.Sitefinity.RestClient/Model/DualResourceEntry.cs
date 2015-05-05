using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class DualResourceEntry
    {
        public bool DisplayBuiltIn { get; set; }
        public string DisplayClassId { get; set; }
        public string DisplayDescription { get; set; }
        public string DisplayKey { get; set; }
        public DateTime DisplayLastModified { get; set; }
        public string DisplayUICulture { get; set; }
        public string DisplayValue { get; set; }
        public bool EditBuiltIn { get; set; }
        public string EditClassId { get; set; }
        public string EditDescription { get; set; }
        public string EditKey { get; set; }
        public DateTime EditLastModified { get; set; }
        public string EditUICulture { get; set; }
        public string EditValue { get; set; }

        public DualResourceEntry() { }
    }
}
