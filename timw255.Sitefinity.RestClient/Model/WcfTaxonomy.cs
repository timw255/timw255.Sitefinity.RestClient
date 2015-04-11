using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfTaxonomy
    {
        public string[] AvailableLanguages { get; set; }
        public string CssClass { get; set; }
        public string Description { get; set; }
        public string EditUrl { get; set; }
        public string[] FirstTwoTaxons { get; set; }
        public string FullName { get; set; }
        public string FullTypeName { get; set; }
        public Guid Id { get; set; }
        public bool IsBuiltIn { get; set; }
        public string Name { get; set; }
        public string SingleItemName { get; set; }
        public string Title { get; set; }
        public int TotalTaxaCount { get; set; }
        public string Type { get; set; }
        public string UserFriendlyType { get; set; }

        public WcfTaxonomy() { }
    }
}
