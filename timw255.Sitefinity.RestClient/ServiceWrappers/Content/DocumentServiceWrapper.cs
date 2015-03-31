using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Libraries.Model;
using Telerik.Sitefinity.Modules.Libraries.Documents;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Content
{
    public class DocumentServiceWrapper : ContentServiceWrapper<Document, DocumentLibraryItemViewModel>
    {
        public DocumentServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Content/DocumentService.svc/";
            this.SF = sf;
        }
    }
}
