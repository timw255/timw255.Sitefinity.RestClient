using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    [JsonObject]
    public sealed class Lstring : IComparable<string>, IEquatable<string>
    {
        public string PersistedValue { get; set; }
        public string Value { get; set; }

        public Lstring() { }

        public bool Equals(string other)
        {
            return this.Value.Equals(other);
        }

        public int CompareTo(string other)
        {
            return this.Value.CompareTo(other);
        }

        public string ToUpper()
        {
            return this.Value.ToUpper();
        }
    }
}
