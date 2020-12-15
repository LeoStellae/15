using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    public class EFcontext : DbContext
    {
        public EFcontext() : base("server=server-bpt; user=sa; port=3306; database=15; password=Qw123456")
        {
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Database.CreateIfNotExists();
        }
    }
}
