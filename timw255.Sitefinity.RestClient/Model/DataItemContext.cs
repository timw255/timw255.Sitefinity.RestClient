using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class DataItemContext<T>
    {
        private T item;

        private string itemType;
        public T Item
        {
            get
            {
                return this.item;
            }
            set
            {
                this.item = value;
                this.itemType = value.GetType().FullName;
            }
        }
        public string ItemType
        {
            get
            {
                return this.itemType;
            }
            set
            {
                this.itemType = value;
            }
        }

        public DataItemContext() { }
    }
}
