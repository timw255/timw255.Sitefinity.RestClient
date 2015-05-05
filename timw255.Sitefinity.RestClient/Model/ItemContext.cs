using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ItemContext<T>
    {
        private T item;
        public virtual T Item
        {
            get
            {
                return this.item;
            }
            set
            {
                this.item = value;
            }
        }

        public ItemContext() { }
    }
}
