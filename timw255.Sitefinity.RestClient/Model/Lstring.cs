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
    public sealed class Lstring : IComparable, IConvertible, IComparable<string>, IEnumerable<char>, IEnumerable, IEquatable<string>
    {
        private string persistedValue = string.Empty;

        private Dictionary<CultureInfo, string> cultureValues = new Dictionary<CultureInfo, string>();

        private ICollection<IDictionary<string, string>> valuesPerCulture;
        public string PersistedValue { get; set; }
        public string Value { get; set; }
        public ICollection<IDictionary<string, string>> ValuesPerCulture
        {
            get
            {
                return this.valuesPerCulture;
            }
            set
            {
                this.valuesPerCulture = value;
            }
        }

        public Lstring()
        {
        }

        public Lstring(string value)
        {
            this.Value = value;
            this.PersistedValue = value;
        }
        
        public char this[int index]
        {
            get
            {
                return this.Value[index];
            }
        }

        public int Length
        {
            get
            {
                return this.Value.Length;
            }
        }

        public int CompareTo(object obj)
        {
            LstringSingleViewModel lstrings = obj as LstringSingleViewModel;
            if (lstrings == null)
            {
                return this.Value.CompareTo(obj);
            }
            return this.Value.CompareTo(lstrings.Value);
        }

        public int CompareTo(string other)
        {
            return this.Value.CompareTo(other);
        }

        public bool Contains(string value)
        {
            return this.Value.Contains(value);
        }

        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            this.Value.CopyTo(sourceIndex, destination, destinationIndex, count);
        }

        public bool EndsWith(string value)
        {
            return this.Value.EndsWith(value);
        }

        public bool EndsWith(string value, StringComparison comparisonType)
        {
            return this.Value.EndsWith(value, comparisonType);
        }

        public bool EndsWith(string value, bool ignoreCase, CultureInfo culture)
        {
            return this.Value.EndsWith(value, ignoreCase, culture);
        }

        public override bool Equals(object obj)
        {
            return this.Value.Equals(obj);
        }

        public bool Equals(string other)
        {
            return this.Value.Equals(other);
        }

        public bool Equals(string value, StringComparison comparisonType)
        {
            return this.Value.Equals(value, comparisonType);
        }

        public CharEnumerator GetEnumerator()
        {
            return this.Value.GetEnumerator();
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.String;
        }

        public int IndexOf(char value)
        {
            return this.Value.IndexOf(value);
        }

        public int IndexOf(string value)
        {
            return this.Value.IndexOf(value);
        }

        public int IndexOf(char value, int startIndex)
        {
            return this.Value.IndexOf(value, startIndex);
        }

        public int IndexOf(string value, int startIndex)
        {
            return this.Value.IndexOf(value, startIndex);
        }

        public int IndexOf(string value, StringComparison comparisonType)
        {
            return this.Value.IndexOf(value, comparisonType);
        }

        public int IndexOf(string value, int startIndex, int count)
        {
            return this.Value.IndexOf(value, startIndex, count);
        }

        public int IndexOf(string value, int startIndex, StringComparison comparisonType)
        {
            return this.Value.IndexOf(value, startIndex, comparisonType);
        }

        public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType)
        {
            return this.Value.IndexOf(value, startIndex, count, comparisonType);
        }

        public int IndexOfAny(char[] anyOf)
        {
            return this.Value.IndexOfAny(anyOf);
        }

        public int IndexOfAny(char[] anyOf, int startIndex)
        {
            return this.Value.IndexOfAny(anyOf, startIndex);
        }

        public int LastIndexOf(char value)
        {
            return this.Value.LastIndexOf(value);
        }

        public int LastIndexOf(string value)
        {
            return this.Value.LastIndexOf(value);
        }

        public int LastIndexOf(char value, int startIndex)
        {
            return this.Value.LastIndexOf(value, startIndex);
        }

        public int LastIndexOf(string value, int startIndex)
        {
            return this.Value.LastIndexOf(value, startIndex);
        }

        public int LastIndexOf(string value, StringComparison comparisonType)
        {
            return this.Value.LastIndexOf(value, comparisonType);
        }

        public int LastIndexOf(string value, int startIndex, int count)
        {
            return this.Value.LastIndexOf(value, startIndex, count);
        }

        public int LastIndexOf(string value, int startIndex, StringComparison comparisonType)
        {
            return this.Value.LastIndexOf(value, startIndex, comparisonType);
        }

        public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType)
        {
            return this.Value.LastIndexOf(value, startIndex, count, comparisonType);
        }

        public int LastIndexOfAny(char[] anyOf)
        {
            return this.Value.LastIndexOfAny(anyOf);
        }

        public int LastIndexOfAny(char[] anyOf, int startIndex)
        {
            return this.Value.LastIndexOfAny(anyOf, startIndex);
        }

        public static bool operator ==(Lstring left, Lstring right)
        {
            if (!object.ReferenceEquals(right, null) && !object.ReferenceEquals(left, null))
            {
                return left.Value == right.Value;
            }
            if (!object.ReferenceEquals(left, null))
            {
                return false;
            }
            return object.ReferenceEquals(right, null);
        }

        public static implicit operator String(Lstring lstring)
        {
            if (lstring == null)
            {
                return null;
            }
            return lstring.Value;
        }

        public static implicit operator Lstring(string value)
        {
            if (value == null)
            {
                return null;
            }
            return new Lstring(value);
        }

        public static bool operator !=(Lstring left, Lstring right)
        {
            if (!object.ReferenceEquals(right, null) && !object.ReferenceEquals(left, null))
            {
                return left.Value != right.Value;
            }
            if (!object.ReferenceEquals(left, null))
            {
                return true;
            }
            return !object.ReferenceEquals(right, null);
        }

        public void SetString(CultureInfo culture, string value)
        {
            this.cultureValues[culture] = value;
            this.Value = value;
        }

        public bool StartsWith(string value)
        {
            return this.Value.StartsWith(value);
        }

        public bool StartsWith(string value, StringComparison comparisonType)
        {
            return this.Value.StartsWith(value, comparisonType);
        }

        public bool StartsWith(string value, bool ignoreCase, CultureInfo culture)
        {
            return this.Value.StartsWith(value, ignoreCase, culture);
        }

        IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.Value.GetEnumerator();
        }

        bool System.IConvertible.ToBoolean(IFormatProvider provider)
        {
            return ((IConvertible)this.Value).ToBoolean(provider);
        }

        byte System.IConvertible.ToByte(IFormatProvider provider)
        {
            return ((IConvertible)this.Value).ToByte(provider);
        }

        char System.IConvertible.ToChar(IFormatProvider provider)
        {
            return ((IConvertible)this.Value).ToChar(provider);
        }

        DateTime System.IConvertible.ToDateTime(IFormatProvider provider)
        {
            return ((IConvertible)this.Value).ToDateTime(provider);
        }

        decimal System.IConvertible.ToDecimal(IFormatProvider provider)
        {
            return ((IConvertible)this.Value).ToDecimal(provider);
        }

        double System.IConvertible.ToDouble(IFormatProvider provider)
        {
            return ((IConvertible)this.Value).ToDouble(provider);
        }

        short System.IConvertible.ToInt16(IFormatProvider provider)
        {
            return ((IConvertible)this.Value).ToInt16(provider);
        }

        int System.IConvertible.ToInt32(IFormatProvider provider)
        {
            return ((IConvertible)this.Value).ToInt32(provider);
        }

        long System.IConvertible.ToInt64(IFormatProvider provider)
        {
            return ((IConvertible)this.Value).ToInt64(provider);
        }

        sbyte System.IConvertible.ToSByte(IFormatProvider provider)
        {
            return ((IConvertible)this.Value).ToSByte(provider);
        }

        float System.IConvertible.ToSingle(IFormatProvider provider)
        {
            return ((IConvertible)this.Value).ToSingle(provider);
        }

        string System.IConvertible.ToString(IFormatProvider provider)
        {
            return ((IConvertible)this.Value).ToString(provider);
        }

        object System.IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            return ((IConvertible)this.Value).ToType(conversionType, provider);
        }

        ushort System.IConvertible.ToUInt16(IFormatProvider provider)
        {
            return ((IConvertible)this.Value).ToUInt16(provider);
        }

        uint System.IConvertible.ToUInt32(IFormatProvider provider)
        {
            return ((IConvertible)this.Value).ToUInt32(provider);
        }

        ulong System.IConvertible.ToUInt64(IFormatProvider provider)
        {
            return ((IConvertible)this.Value).ToUInt64(provider);
        }

        public char[] ToCharArray()
        {
            return this.Value.ToCharArray();
        }

        public char[] ToCharArray(int startIndex, int length)
        {
            return this.Value.ToCharArray(startIndex, length);
        }

        public string ToLower()
        {
            return this.Value.ToLower();
        }

        public string ToLower(CultureInfo culture)
        {
            return this.Value.ToLower(culture);
        }

        public string ToLowerInvariant()
        {
            return this.Value.ToLowerInvariant();
        }

        public override string ToString()
        {
            return this.Value;
        }

        public string ToUpper()
        {
            return this.Value.ToUpper();
        }

        public string ToUpper(CultureInfo culture)
        {
            return this.Value.ToUpper(culture);
        }

        public string ToUpperInvariant()
        {
            return this.Value.ToUpperInvariant();
        }

        public string Trim()
        {
            return this.Value.Trim();
        }

        public string Trim(params char[] trimChars)
        {
            return this.Value.Trim(trimChars);
        }

        public string TrimEnd(params char[] trimChars)
        {
            return this.Value.TrimEnd(trimChars);
        }

        public string TrimStart(params char[] trimChars)
        {
            return this.Value.TrimStart(trimChars);
        }
    }
}
