using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class MediaQueryViewModel
    {
        public AdditionalCssViewModel AdditionalCss { get; set; }
        public string AppliedToString { get; set; }
        public string Behavior { get; set; }
        public string BehaviorDescription { get; set; }
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public LayoutTransformationViewModel[] LayoutTransformations { get; set; }
        public Guid MiniSitePageId { get; set; }
        public string Name { get; set; }
        public List<NavigationTransformationViewModel> NavigationTransformations { get; set; }
        public int PagesCount { get; set; }
        public int PageTemplatesCount { get; set; }
        public MediaQueryRuleViewModel[] Rules { get; set; }
        public string Status { get; set; }

        public MediaQueryViewModel() { }
    }
}
