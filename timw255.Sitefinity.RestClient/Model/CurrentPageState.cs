using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class CurrentPageState
    {
        public ItemState ItemState { get; set; }
        public string Message { get; set; }

        public CurrentPageState() { }
    }
}
