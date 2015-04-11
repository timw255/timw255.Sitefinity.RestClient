using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ContentBlockPageViewModel
    {
        public int BlocksCount { get; set; }
        public Guid Id { get; set; }
        public string PageBreadcrumb { get; set; }
        public string PageTitle { get; set; }

        public ContentBlockPageViewModel() { }
    }
}
