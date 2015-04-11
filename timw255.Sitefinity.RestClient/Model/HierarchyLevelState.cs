using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class HierarchyLevelState
    {
        public int Skip { get; set; }
        public int Take { get; set; }
        public int Total { get; set; }

        public HierarchyLevelState() { }
    }
}
