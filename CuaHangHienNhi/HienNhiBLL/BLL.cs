using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HienNhiDTOs;
using System.Data;
using System.Data.SqlClient;

namespace HienNhiBLL
{
    public class BLL
    {
        private SqlConnection con;
        //private NguoiDungDTO user;

        public BLL()
        {
            try
            {
                this.con = new SqlConnection(CommonFunction.getConnectionString());
            }
            catch (Exception ex)
            {
                MyExceptionNS.MyException myEx = new MyExceptionNS.MyException();
                myEx.className = this.GetType().Name;
                myEx.errMsg = ex.Message;
                throw myEx;
            }

        }

        #region UserBLL
        public int verifyLogin(string userName, string pw)  //return the role code (1: admin, 2: user, 0: invalid)
        {
            try
            {

                string command = "select role from NguoiDung where Username = @un and password = @pw";
                SqlCommand cmd = new SqlCommand(command, this.con);
                cmd.Parameters.Add("@un", SqlDbType.VarChar);
                cmd.Parameters.Add("@pw", SqlDbType.VarChar);
                cmd.Parameters["@un"].Value = userName;
                cmd.Parameters["@pw"].Value = pw;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    con.Close();
                    return 0;
                }
                else
                {
                    dr.Read();
                    Int16 result = Convert.ToInt16(dr["Role"].ToString());
                    con.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MyExceptionNS.MyException myEx = new MyExceptionNS.MyException();
                myEx.className = this.GetType().Name;
                myEx.errMsg = ex.Message;
                throw myEx;
            }

        }
        
        #endregion

    }
}
