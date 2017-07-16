using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class connect
    {
        protected SqlConnection dbConn = new SqlConnection(@"Data Source=1RQ9PQOOHJNY2OJ\SQLEXPRESS;Initial Catalog=QLHSSV;Integrated Security=True");
    }
}
