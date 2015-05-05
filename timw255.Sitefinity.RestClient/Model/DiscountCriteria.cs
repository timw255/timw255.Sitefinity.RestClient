using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class DiscountCriteria : IDynamicFieldsContainer
    {
        public string ApplicationName { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid Id { get; set; }
        public DateTime LastModified { get; set; }
        public Guid RoleId { get; set; }
        public Guid UserId { get; set; }

        public DiscountCriteria() { }
    }
}
