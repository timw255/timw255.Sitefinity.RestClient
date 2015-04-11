using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SyncItem
    {
        public string CalculatedBasePath { get; set; }
        public DateTime CalculatedDate { get; set; }
        public SyncItemOperation CalculatedOperation { get; set; }
        public string CalculatedPath { get; set; }
        public int CalculatedVersion { get; set; }
        public DateTime Date { get; set; }
        public Guid Id { get; set; }
        public bool InConflict { get; set; }
        public SyncItemOperation Operation { get; set; }
        public string Path { get; set; }
        public SyncItemType Type { get; set; }
        public int Version { get; set; }

        public SyncItem() { }
    }
}
