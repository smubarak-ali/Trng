using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranglo.Auth.Model;
using Dapper;

namespace Tranglo.Auth.DataAccess
{
    public class UserRepository
    {
        public User ValidateUser(string username, string password)
        {
            var user = new User();
            using (var con = GetConnection())
            {
                string cmdStr = "SELECT * FROM STSTest WHERE Username = @usrname AND Password=@pass";
                try
                {
                    user = con.Query<User>(cmdStr, new { usrname = username, pass = password }).FirstOrDefault();
                    CloseConnection(con);
                }//try
                catch (Exception ex)
                {
                    throw ex;
                }//catch
            }//using

            return user;
        }//ValidateUser

        private SqlConnection GetConnection()
        {
            string connectionStr = "Data Source=192.168.1.90; Initial Catalog=dbTempo; Persist Security Info=True; User ID=dbTempoUser; Password=m1loIc3";
            var con = new SqlConnection(connectionStr);
            return con;
        }//GetConnection

        private void CloseConnection(SqlConnection con)
        {
            if (con != null && con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }//if
        }//CloseConnection
    }
}
