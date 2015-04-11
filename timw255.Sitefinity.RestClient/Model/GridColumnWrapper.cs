using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class GridColumnWrapper
    {
        public int ColumnOrdinal { get; set; }
        public string GridEditorCssClass { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool ShowInGrid { get; set; }
        public string Title { get; set; }

        public GridColumnWrapper() { }
    }
}
