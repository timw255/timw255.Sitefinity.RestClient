using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ContentTypeItemFieldContext
    {
        public string AddressFieldMode { get; set; }
        public bool AllowImageLibrary { get; set; }
        public bool AllowMultipleFiles { get; set; }
        public bool AllowMultipleImages { get; set; }
        public bool AllowMultipleVideos { get; set; }
        public bool AllowNulls { get; set; }
        public bool CanCreateItemsWhileSelecting { get; set; }
        public bool CanSelectMultipleItems { get; set; }
        public bool CheckedByDefault { get; set; }
        public string ChoiceRenderType { get; set; }
        public string Choices { get; set; }
        public Guid ClassificationId { get; set; }
        public string ColumnName { get; set; }
        public string DBLength { get; set; }
        public string DBType { get; set; }
        public int DecimalPlacesCount { get; set; }
        public string DefaultValue { get; set; }
        public bool DisableLinkParser { get; set; }
        public int DropDownListDefaulValueIndex { get; set; }
        public string FileExtensions { get; set; }
        public int FileMaxSize { get; set; }
        public string FrontendWidgetLabel { get; set; }
        public string FrontendWidgetTypeName { get; set; }
        public int GridColumnOrdinal { get; set; }
        public Guid Id { get; set; }
        public string ImageExtensions { get; set; }
        public int ImageMaxSize { get; set; }
        public bool IncludeInIndexes { get; set; }
        public string InstructionalChoice { get; set; }
        public string InstructionalText { get; set; }
        public bool IsHiddenField { get; set; }
        public bool IsLocalizable { get; set; }
        public bool IsRequired { get; set; }
        public bool IsRequiredToSelectCheckbox { get; set; }
        public bool IsRequiredToSelectDdlValue { get; set; }
        public bool IsTransient { get; set; }
        public string LengthValidationMessage { get; set; }
        public int? MaxLength { get; set; }
        public string MaxNumberRange { get; set; }
        public string MediaType { get; set; }
        public int? MinLength { get; set; }
        public string MinNumberRange { get; set; }
        public string Name { get; set; }
        public string NumberUnit { get; set; }
        public int Ordinal { get; set; }
        public Guid ParentSectionId { get; set; }
        public string RegularExpression { get; set; }
        public string RelatedDataProvider { get; set; }
        public string RelatedDataType { get; set; }
        public bool ShowInGrid { get; set; }
        public string Title { get; set; }
        public string TypeName { get; set; }
        public string TypeUIName { get; set; }
        public string VideoExtensions { get; set; }
        public int VideoMaxSize { get; set; }
        public string WidgetTypeName { get; set; }

        public ContentTypeItemFieldContext() { }
    }
}
