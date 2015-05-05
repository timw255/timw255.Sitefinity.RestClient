using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class MediaQueryRuleViewModel
    {
        public string AspectRatio { get; set; }
        public string Description { get; set; }
        public string DeviceTypeName { get; set; }
        public string ExactHeight { get; set; }
        public string ExactWidth { get; set; }
        public SizeType HeightType { get; set; }
        public bool IsGrid { get; set; }
        public bool IsManualMediaQuery { get; set; }
        public bool IsMonochrome { get; set; }
        public string MaxHeight { get; set; }
        public string MaxWidth { get; set; }
        public string MediaQueryRule { get; set; }
        public string MinHeight { get; set; }
        public string MinWidth { get; set; }
        public DeviceOrientation Orientation { get; set; }
        public Guid ParentMediaQueryId { get; set; }
        public string Resolution { get; set; }
        public SizeType WidthType { get; set; }

        public MediaQueryRuleViewModel() { }
    }
}
