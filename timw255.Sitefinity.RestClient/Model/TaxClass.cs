using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class TaxClass : IDynamicFieldsContainer
    {
        public string[] AvailableLanguages { get; set; }
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public Guid Owner { get; set; }
        public ContentLifecycleStatus Status { get; set; }
        public Lstring Title { get; set; }
        public int Version { get; set; }
        public bool Visible { get; set; }

        public TaxClass() { }
    }
}
