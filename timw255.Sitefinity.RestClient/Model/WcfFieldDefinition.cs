using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfFieldDefinition
    {
        public bool AllowMultipleFiles { get; set; }
        public bool AllowMultipleImages { get; set; }
        public bool AllowMultipleSelection { get; set; }
        public bool AllowMultipleVideos { get; set; }
        public string ChoiceItemsTitles { get; set; }
        public string Choices { get; set; }
        public string CssClass { get; set; }
        public Guid DefaultImageId { get; set; }
        public string DefaultItemTypeName { get; set; }
        public string DefaultSrc { get; set; }
        public string DefaultStringValue { get; set; }
        public string DefaultValue { get; set; }
        public string Description { get; set; }
        public string Example { get; set; }
        public ExpandableControlDefinition ExpandableDefinitionConfig { get; set; }
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public string FieldVirtualPath { get; set; }
        public string FileExtensions { get; set; }
        public string FrontendWidgetLabel { get; set; }
        public string FrontendWidgetTypeName { get; set; }
        public bool Hidden { get; set; }
        public bool HideTitle { get; set; }
        public bool IsLocalizable { get; set; }
        public int? MaxFileSize { get; set; }
        public int? MaxHeight { get; set; }
        public int? MaxWidth { get; set; }
        public string MediaType { get; set; }
        public bool MutuallyExclusive { get; set; }
        public string ProviderNameForDefaultImage { get; set; }
        public string RelatedDataProvider { get; set; }
        public string RelatedDataType { get; set; }
        public RenderChoicesAs RenderChoiceAs { get; set; }
        public string ResourceClassId { get; set; }
        public string SectionName { get; set; }
        public int[] SelectedChoicesIndex { get; set; }
        public bool SortAlphabetically { get; set; }
        public string TaxonomyId { get; set; }
        public string Title { get; set; }
        public ValidatorDefinition ValidatorDefinition { get; set; }
        public string[] VisibleViews { get; set; }

        public WcfFieldDefinition() { }
    }
}
