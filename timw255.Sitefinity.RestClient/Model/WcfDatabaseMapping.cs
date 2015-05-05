using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class WcfDatabaseMapping
    {
        public string ClrType { get; set; }
        public string ColumnName { get; set; }
        public string DbLength { get; set; }
        public string DbPrecision { get; set; }
        public string DbScale { get; set; }
        public string DbSqlType { get; set; }
        public string DbType { get; set; }
        public bool Indexed { get; set; }
        public bool Nullable { get; set; }

        public WcfDatabaseMapping() { }
    }
}
