using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ContentTypeContext
    {
        public bool CheckFieldPermissions { get; set; }
        public string ContentTypeDescription { get; set; }
        public Guid ContentTypeId { get; set; }
        public string ContentTypeItemName { get; set; }
        public string ContentTypeItemTitle { get; set; }
        public string ContentTypeName { get; set; }
        public Guid ContentTypePageId { get; set; }
        public string ContentTypeStatus { get; set; }
        public string ContentTypeStatusTitle { get; set; }
        public string ContentTypeTitle { get; set; }
        public ContentTypeItemFieldContext[] Fields { get; set; }
        public bool IsDeletable { get; set; }
        public bool IsSelfReferencing { get; set; }
        public string LastModified { get; set; }
        public string MainShortTextFieldName { get; set; }
        public Guid ModuleId { get; set; }
        public string Owner { get; set; }
        public Guid ParentContentTypeId { get; set; }
        public string UpdateContext { get; set; }

        public ContentTypeContext() { }
    }
}
