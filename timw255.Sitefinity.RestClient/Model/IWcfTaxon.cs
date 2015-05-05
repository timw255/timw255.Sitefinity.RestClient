using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public interface IWcfTaxon
    {
        DictionaryObjectViewModel Attributes { get; set; }
        string[] AvailableLanguages { get; set; }
        string Description { get; set; }
        Guid Id { get; set; }
        uint ItemsCount { get; set; }
        string Name { get; set; }
        string Synonyms { get; set; }
        string TaxonomyName { get; set; }
        string Title { get; set; }
        string UrlName { get; set; }
        string UrlPath { get; set; }
    }
}
