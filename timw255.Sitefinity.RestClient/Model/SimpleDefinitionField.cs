using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SimpleDefinitionField
    {
        public bool AllowMultipleTaxons { get; set; }
        public string ClrType { get; set; }
        public string DBType { get; set; }
        public string DefaultValue { get; set; }
        public bool HideInUI { get; set; }
        public bool IsMetaField { get; set; }
        public bool IsModified { get; set; }
        public bool IsRequired { get; set; }
        public int MaxLength { get; set; }
        public string Name { get; set; }
        public int Precision { get; set; }
        public string SQLDBType { get; set; }
        public string TaxonomyId { get; set; }
        public string TaxonomyProviderName { get; set; }
        public string Title { get; set; }

        public SimpleDefinitionField() { }
    }
}
