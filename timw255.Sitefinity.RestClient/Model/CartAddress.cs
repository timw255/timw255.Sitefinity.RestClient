using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class CartAddress : IDynamicFieldsContainer
    {
        public string Address { get; set; }
        public string Address2 { get; set; }
        public AddressType AddressType { get; set; }
        public string ApplicationName { get; set; }
        public string City { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string FirstName { get; set; }
        public Guid Id { get; set; }
        public DateTime LastModified { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string PhoneExtension { get; set; }
        public string PostalCode { get; set; }
        public string StateRegion { get; set; }

        public CartAddress() { }
    }
}
