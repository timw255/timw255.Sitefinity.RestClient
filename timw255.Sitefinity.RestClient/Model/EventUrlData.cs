﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class EventUrlData : UrlData
    {
        public IDataItem Parent { get; set; }

        public EventUrlData() { }
    }
}
