using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ConfigPropertyCollection : KeyedCollection<string, ConfigProperty>
    {
        public ConfigProperty[] KeyProperties { get; set; }

        public ConfigPropertyCollection() { }

        protected override string GetKeyForItem(ConfigProperty item)
        {
            return item.Name;
        }
    }
}
