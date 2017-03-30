using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZWJ.New.Web.EF.Repository
{
    public class SqlHelper
    {
        protected SqlConnection conn;
        //打开连接
        public bool OpenConnection()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            try
            {
                bool result = true;
                if (conn.State.ToString() != "Open")
                {
                    conn.Open();
                }
                return result;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }
    }
}
