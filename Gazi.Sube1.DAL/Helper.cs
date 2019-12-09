using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.Sube1.DAL//Data Access Layer
{
    public class Helper : IDisposable
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
        SqlCommand cmd;
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p)
        {
            try
            {
                cmd = new SqlCommand(cmdtext, cn);
                if (p != null)
                {
                    cmd.Parameters.AddRange(p);
                }
                OpenConnection();
                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p)
        {
            try
            {
                cmd = new SqlCommand(cmdtext, cn);
                if (p != null)
                {
                    cmd.Parameters.AddRange(p);
                }
                OpenConnection();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetDataTable(string cmdtext)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmdtext, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void OpenConnection()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            if (cn != null)
            {
                cn.Dispose();
            }

            if (cmd != null)
            {
                cmd.Dispose();
            }
        }
    }
}
