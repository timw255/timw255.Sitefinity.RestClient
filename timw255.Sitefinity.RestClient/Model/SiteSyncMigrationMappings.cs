﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class SiteSyncMigrationMappings
    {
        public Dictionary<string, Dictionary<string, Dictionary<string, string>>> mappings { get; set; }

        public SiteSyncMigrationMappings() { }
    }
}
