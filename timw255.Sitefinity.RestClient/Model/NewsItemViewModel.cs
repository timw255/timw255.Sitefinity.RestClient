using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class NewsItemViewModel : ContentViewModelBase
    {
        public override string Author { get; set; }

        public NewsItemViewModel() { }
    }
}
