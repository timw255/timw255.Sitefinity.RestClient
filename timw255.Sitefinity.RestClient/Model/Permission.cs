using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class Permission
    {
        public string ApplicationName { get; set; }
        public int Deny { get; set; }
        public int Grant { get; set; }
        public Guid Id { get; set; }
        public DateTime LastModified { get; set; }
        public Guid ObjectId { get; set; }
        public Guid PrincipalId { get; set; }

        public Permission() { }
    }
}
