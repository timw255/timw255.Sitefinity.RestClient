using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SyncShot
    {
        public List<SyncItem> Items { get; set; }
        public string SourceDirectoryPath { get; set; }

        public SyncShot() { }
    }
}
