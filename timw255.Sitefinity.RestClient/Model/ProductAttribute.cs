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
    public class ProductAttribute : IDynamicFieldsContainer
    {
        public string AppliedTo { get; set; }
        public string AppliedToJson { get; set; }
        public string[] AvailableLanguages { get; set; }
        public DateTime DateCreated { get; set; }
        public List<string> FirstTwoProductAttributeValues { get; set; }
        public List<string> FirstTwoProductTypes { get; set; }
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public float Ordinal { get; set; }
        public Guid Owner { get; set; }
        public string SortOrder { get; set; }
        public ContentLifecycleStatus Status { get; set; }
        public Lstring Title { get; set; }
        public int TotalProductAttributeValuesCount { get; set; }
        public int TotalProductTypesCount { get; set; }
        public bool Visible { get; set; }

        public ProductAttribute() { }
    }
}
