using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class EventViewModel : HierarchicalContentViewModelBase
    {
        public bool AllDayEvent { get; set; }
        public string CalendarColor { get; set; }
        public string CalendarTitle { get; set; }
        public DateTime? EventEnd { get; set; }
        public double EventEndUtcOffset { get; set; }
        public DateTime? EventStart { get; set; }
        public double EventStartUtcOffset { get; set; }
        public Guid ParentId { get; set; }

        public EventViewModel() { }
    }
}
