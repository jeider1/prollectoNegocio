using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace capaDatos
{
    public class datos
    {
        SqlConnection sbd = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);

        public DataTable dLista()
        {
            SqlCommand cmd = new SqlCommand("spLis", sbd);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter datas = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            datas.Fill(dt);
            return dt;
        }
    }
}
