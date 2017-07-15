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
       protected SqlConnection dbConn = new SqlConnection(@"Data Source=HUUTHUAN\SQLEXPRESS;Initial Catalog=QLHSSV_TTLL;Integrated Security=True");
    }
}
