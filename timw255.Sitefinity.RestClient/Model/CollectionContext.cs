using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class CollectionContext<T>
    {
        private IEnumerable<T> items;

        private static CollectionContext<T> empty;
        public ICollection<KeyValuePair<string, string>> Context { get; set; }

        public static CollectionContext<T> Empty
        {
            get
            {
                if (CollectionContext<T>.empty == null)
                {
                    CollectionContext<T> collectionContext = new CollectionContext<T>(new T[0])
                    {
                        TotalCount = 0
                    };
                    CollectionContext<T>.empty = collectionContext;
                }
                return CollectionContext<T>.empty;
            }
        }
        public bool IsGeneric { get; set; }
        public IEnumerable<T> Items
        {
            get
            {
                if (this.items == null)
                {
                    this.items = new Collection<T>();
                }
                return this.items;
            }
            set
            {
                this.items = value;
            }
        }
        public int TotalCount { get; set; }

        public CollectionContext() { }

        public CollectionContext(IEnumerable<T> items)
        {
            this.items = items;
        }
    }
}
