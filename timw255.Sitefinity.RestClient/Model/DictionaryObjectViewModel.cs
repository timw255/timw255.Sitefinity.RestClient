using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [Serializable]
    public class DictionaryObjectViewModel : ISerializable
    {
        private IDictionary<string, string> innerDictionary;

        public IDictionary<string, string> Dictionary
        {
            get
            {
                if (this.innerDictionary == null)
                {
                    this.innerDictionary = new Dictionary<string, string>();
                }
                return this.innerDictionary;
            }
        }

        public DictionaryObjectViewModel()
        {
        }

        public DictionaryObjectViewModel(IDictionary<string, string> initDictionary)
            : this()
        {
            this.CopyFrom(initDictionary);
        }

        protected DictionaryObjectViewModel(SerializationInfo info, StreamingContext context)
            : this()
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }
            SerializationInfoEnumerator enumerator = info.GetEnumerator();
            while (enumerator.MoveNext())
            {
                SerializationEntry current = enumerator.Current;
                string str = null;
                object[] value = current.Value as object[];
                str = (value == null ? current.Value.ToString() : JsonConvert.SerializeObject(value));//JsonSerializer.SerializeToString<object[]>(value));
                this.Dictionary[current.Name] = str;
            }
        }

        public void CopyFrom(IDictionary<string, string> sourceDictionary)
        {
            if (sourceDictionary != null)
            {
                foreach (KeyValuePair<string, string> value in sourceDictionary)
                {
                    this.Dictionary[value.Key] = value.Value;
                }
            }
        }

        public void CopyTo(IDictionary<string, string> targetDictionary)
        {
            if (this.innerDictionary != null && this.innerDictionary.Count > 0)
            {
                foreach (KeyValuePair<string, string> value in this.innerDictionary)
                {
                    targetDictionary[value.Key] = value.Value;
                }
            }
        }

        private Type GetEntryType(string key, string value)
        {
            string str = null;
            int num = key.LastIndexOf('\u005F');
            if (num > 0 && num < key.Length - 2)
            {
                str = key.Substring(num + 1);
            }
            if (!string.IsNullOrEmpty(str))
            {
                string lowerInvariant = str.ToLowerInvariant();
                string str1 = lowerInvariant;
                if (lowerInvariant != null)
                {
                    if (str1 == "boolean")
                    {
                        return typeof(bool);
                    }
                    if (str1 == "integer")
                    {
                        return typeof(int);
                    }
                }
            }
            return typeof(object);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info != null)
            {
                foreach (KeyValuePair<string, string> dictionary in this.Dictionary)
                {
                    Type entryType = this.GetEntryType(dictionary.Key, dictionary.Value);
                    if (entryType == typeof(object))
                    {
                        object value = dictionary.Value;
                        if (!string.IsNullOrEmpty(dictionary.Value) && dictionary.Value.StartsWith("[") && dictionary.Value.EndsWith("]"))
                        {
                            try
                            {
                                value = JsonConvert.DeserializeObject<object[]>(dictionary.Value);//JsonSerializer.DeserializeFromString<object[]>(dictionary.Value);
                            }
                            catch
                            {
                            }
                        }
                        info.AddValue(dictionary.Key, value);
                    }
                    else
                    {
                        object obj1 = JsonConvert.DeserializeObject(dictionary.Value, entryType);//JsonSerializer.DeserializeFromString(dictionary.Value, entryType);
                        info.AddValue(dictionary.Key, obj1);
                        break;
                    }
                }
            }
        }
    }
}
