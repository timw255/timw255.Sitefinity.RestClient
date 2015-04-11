using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfHierarchicalTaxon : IWcfTaxon
    {
        public DictionaryObjectViewModel Attributes { get; set; }
        public string[] AvailableLanguages { get; set; }
        public string Description { get; set; }
        public bool HasChildren { get; set; }
        public Guid Id { get; set; }
        public uint ItemsCount { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public float Ordinal { get; set; }
        public Guid? ParentTaxonId { get; set; }
        public string ParentTaxonTitle { get; set; }
        public string Synonyms { get; set; }
        public Guid? TaxonomyId { get; set; }
        public string TaxonomyName { get; set; }
        public string Title { get; set; }
        public string TitlesPath { get; set; }
        public string UrlName { get; set; }
        public string UrlPath { get; set; }

        public WcfHierarchicalTaxon() { }
    }
}
