using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class FormDescriptionViewModel
    {
        public DictionaryObjectViewModel Attributes { get; set; }
        public string[] AvailableLanguages { get; set; }
        public List<string> Category { get; set; }
        public string CssClass { get; set; }
        public DateTime? DateCreated { get; set; }
        public string DuplicateName { get; set; }
        public string DuplicateTitle { get; set; }
        public string EditUrl { get; set; }
        public int EntriesCount { get; set; }
        public FormLabelPlacement FormLabelPlacement { get; set; }
        public bool HasSubscription { get; set; }
        public bool HasSubscriptionAfterFormUpdate { get; set; }
        public Guid Id { get; set; }
        public DateTime? LastModified { get; set; }
        public WcfContentLifecycleStatus LifecycleStatus { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string RedirectPageUrl { get; set; }
        public string RedirectPageUrlAfterUpdate { get; set; }
        public string ResponsesUrl { get; set; }
        public Guid SourceLanguageObjectId { get; set; }
        public string Status { get; set; }
        public string StatusText { get; set; }
        public SubmitAction SubmitAction { get; set; }
        public SubmitAction SubmitActionAfterUpdate { get; set; }
        public SubmitRestriction SubmitRestriction { get; set; }
        public string[] SubscribedEmails { get; set; }
        public string[] SubscribedEmailsAfterFormUpdate { get; set; }
        public string SuccessMessage { get; set; }
        public string SuccessMessageAfterFormUpdate { get; set; }
        public List<string> Tags { get; set; }
        public string Title { get; set; }
        public string UrlName { get; set; }
        public string ViewUrl { get; set; }

        public FormDescriptionViewModel() { }
    }
}
