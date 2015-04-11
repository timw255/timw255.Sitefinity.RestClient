using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfFlatTaxon : IWcfTaxon
    {
        public DictionaryObjectViewModel Attributes { get; set; }
        public string[] AvailableLanguages { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public uint ItemsCount { get; set; }
        public string Name { get; set; }
        public string Synonyms { get; set; }
        public Guid TaxonomyId { get; set; }
        public string TaxonomyName { get; set; }
        public string Title { get; set; }
        public string UrlName { get; set; }
        public string UrlPath { get; set; }

        public WcfFlatTaxon() { }
    }
}
