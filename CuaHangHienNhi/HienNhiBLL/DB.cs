using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HienNhiDTOs;
using System.Data.SqlClient;
using MyExceptionNS;

namespace HienNhiBLL
{
    public class DB
    {
        private SqlConnection con;

        public DB()
        {
            
            this.con = new SqlConnection(CommonFunction.getConnectionString());
        }

        public SqlDataReader queryTable(string tableName)
        {
            try
            {
                string command = "select * from " + tableName;
                this.con.Open();
                SqlCommand cmd = new SqlCommand(command, this.con);
                SqlDataReader result = cmd.ExecuteReader();
                this.con.Close();
                return result;
            }
            catch (Exception ex)
            {
                MyException e = new MyException();
                e.className = this.GetType().Name;
                e.errMsg = ex.Message;
                throw e;
            }
        }

        /* public SqlDataReader queryTableWithConditions(string tableName, List<String> parameters, List<String> value)
        {
            try
            {
                //check if the number of params and values mismatch or not?
                if (parameters.Capacity != value.Capacity)
                {
                    MyException ex = new MyException();
                    ex.className = this.GetType().Name;
                    ex.errMsg = "Number of parameters and number of values are mismatch.";
                        throw ex;
                }
                //if the number of params and values are the same, then check if the number of param = 0
                if (parameters.Capacity == 0)
                {
                    return this.queryTable(tableName);
                }
                //if the number of params is > 0, then continue to build the query
                StringBuilder command = new StringBuilder("select * from ");
                command.Append(tableName + " ");
                command.Append("where ");
                command.Append(parameters[0]);
                command.Append("= " + "'" + value[0] + "'");
                //if there are more params, then continue to build the query with 'AND' operator
                for (int i = 1; i <= parameters.Capacity; i++)
                {
                    command.Append(" and ");
                    command.Append(parameters[i].Contains("@")?parameters[i]:"@"+parameters[i]);
                    command.Append("= " + "'" + value[i] + "'");
                }
                //execute the query
                this.con.Open();
                SqlCommand cmd = new SqlCommand(command.ToString(),this.con);
                SqlDataReader result = cmd.ExecuteReader();
                this.con.Close();
                return result;


            }
            catch (MyException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                MyException myEx = new MyException();
                myEx.className = this.GetType().Name;
                myEx.errMsg = ex.Message;

                throw ex;
            }

        }
        */
    }
}
