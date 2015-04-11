﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timw255.Sitefinity.RestClient.Model;

namespace timw255.Sitefinity.RestClient.ServiceWrappers.Content
{
    public class BlogServiceWrapper : ContentServiceWrapper<Blog, BlogViewModel>
    {
        public BlogServiceWrapper(SitefinityRestClient sf)
        {
            this.ServiceUrl = "Sitefinity/Services/Content/BlogService.svc/";
            this.SF = sf;
        }
    }
}
