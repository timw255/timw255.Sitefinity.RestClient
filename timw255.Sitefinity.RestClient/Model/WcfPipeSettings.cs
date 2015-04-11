using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfPipeSettings
    {
        public string AdditionalFilter { get; set; }
        public string AdditionalSettings { get; set; }
        public string ContentLocation { get; set; }
        public Guid? ContentLocationPageID { get; set; }
        public string ContentName { get; set; }
        public string ContentUrlLocation { get; set; }
        public SimpleDefinitionField[] Definition { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsInbound { get; set; }
        public List<string> LanguageIds { get; set; }
        public MappingSettingsViewModel MappingSettings { get; set; }
        public string PipeName { get; set; }
        public string PublishingPointName { get; set; }
        public string ScheduleTime { get; set; }
        public string Settings { get; set; }
        public string Title { get; set; }
        public string UIDescription { get; set; }
        public string UIName { get; set; }

        public WcfPipeSettings() { }
    }
}
