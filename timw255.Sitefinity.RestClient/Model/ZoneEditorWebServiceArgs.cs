using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ZoneEditorWebServiceArgs
    {
        public Dictionary<string, string> Attributes { get; set; }
        public string ClassId { get; set; }
        public string CommandName { get; set; }
        public string ControlType { get; set; }
        public string[] CssLinkUrls { get; set; }
        public string CustomTitleHtml { get; set; }
        public string Description { get; set; }
        public string DockId { get; set; }
        public string ErrorMessage { get; set; }
        public string Html { get; set; }
        public Guid Id { get; set; }
        public string LayoutControlDataID { get; set; }
        public string LayoutHtml { get; set; }
        public string LayoutTemlpate { get; set; }
        public DesignMediaType MediaType { get; set; }
        public JsonDictionary<LayoutControlDataPermissions> ModifiedLayoutPermissios { get; set; }
        public string Ordinal { get; set; }
        public Guid PageId { get; set; }
        public Guid PageNodeId { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
        public Dictionary<string, string> Permissions { get; set; }
        public string PlaceholderId { get; set; }
        public string PreviousPlaceholderID { get; set; }
        public bool ReloadControlsWithSameKey { get; set; }
        public Guid SiblingId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        public ZoneEditorWebServiceArgs() { }
    }
}
