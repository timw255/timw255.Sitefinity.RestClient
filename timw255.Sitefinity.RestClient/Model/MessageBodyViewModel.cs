using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class MessageBodyViewModel
    {
        public string BodyText { get; set; }
        public Guid Id { get; set; }
        public WcfPageTemplate InternalPageTemplate { get; set; }
        public Guid InternalPageTemplateId { get; set; }
        public bool IsTemplate { get; set; }
        public MessageBodyType MessageBodyType { get; set; }
        public string Name { get; set; }
        public string PlainTextVersion { get; set; }
        public string RawSourceHtml { get; set; }
        public string RawSourcePlainText { get; set; }
        public string TemplateTypeUX { get; set; }

        public MessageBodyViewModel() { }
    }
}
