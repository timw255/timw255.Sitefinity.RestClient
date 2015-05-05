using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfPageNode
    {
        public bool AdditionalUrlsRedirectToDefaultOne { get; set; }
        public bool AllowMultipleUrls { get; set; }
        public bool AllowParameterValidation { get; set; }
        public string[] AvailableLanguages { get; set; }
        public string Extension { get; set; }
        public string FullUrl { get; set; }
        public bool HasChildren { get; set; }
        public bool HasTranslationSiblings { get; set; }
        public Guid Id { get; set; }
        public bool IsExternal { get; set; }
        public string LinkedNodeFullUrl { get; set; }
        public Guid LinkedNodeId { get; set; }
        public string LinkedNodeProvider { get; set; }
        public string LinkedNodeTitle { get; set; }
        public LocalizationStrategy LocalizationStrategy { get; set; }
        public string MultipleNavigationNodes { get; set; }
        public NodeType NodeType { get; set; }
        public bool OpenNewWindow { get; set; }
        public Guid ParentId { get; set; }
        public string Path { get; set; }
        public string ProviderName { get; set; }
        public string RedirectUrl { get; set; }
        public Guid RootId { get; set; }
        public LstringSingleViewModel Title { get; set; }
        public string TitlesPath { get; set; }
        public bool WasPublished { get; set; }

        public WcfPageNode() { }
    }
}
