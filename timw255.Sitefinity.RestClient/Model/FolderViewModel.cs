using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class FolderViewModel
    {
        public bool HasChildren { get; set; }
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public string Path { get; set; }
        public Guid RootId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        public FolderViewModel() { }
    }
}
