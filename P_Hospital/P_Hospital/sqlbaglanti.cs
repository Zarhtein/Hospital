using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace P_Hospital
{
    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection ("Data Source=LAPTOP-8MN6KUL9;Initial Catalog=Hastane_Yönetimi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
