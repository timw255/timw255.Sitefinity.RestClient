using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class Calendar : IDynamicFieldsContainer
    {
        public string[] AvailableLanguages { get; set; }
        public string Color { get; set; }
        public Lstring Description { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Guid Id { get; set; }
        public Guid Owner { get; set; }
        public DateTime PublicationDate { get; set; }
        public Lstring Title { get; set; }
        public Lstring UrlName { get; set; }

        public Calendar() { }
    }
}
