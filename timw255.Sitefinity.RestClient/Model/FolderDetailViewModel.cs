using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class FolderDetailViewModel
    {
        public Lstring Description { get; set; }
        public Guid Id { get; set; }
        public Guid ParentId { get; set; }
        public Lstring Title { get; set; }

        public FolderDetailViewModel() { }
    }
}
