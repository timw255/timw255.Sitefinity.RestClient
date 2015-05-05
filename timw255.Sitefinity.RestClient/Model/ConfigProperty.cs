using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ConfigProperty
    {
        public TypeConverter Converter { get; set; }
        public object DefaultValue { get; set; }
        public bool IsDefaultCollection { get; set; }
        public bool IsKey { get; set; }
        public bool IsRequired { get; set; }
        public string Name { get; set; }
        public Type Type { get; set; }
        public ConfigurationValidatorBase Validator { get; set; }

        public ConfigProperty() { }
    }
}
