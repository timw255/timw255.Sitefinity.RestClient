using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class LanguageData
    {
        public LifecycleState ContentState { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Guid Id { get; set; }
        public string Language { get; set; }
        public DateTime PublicationDate { get; set; }
        public DateTime? ScheduledDate { get; set; }

        public LanguageData() { }
    }
}
