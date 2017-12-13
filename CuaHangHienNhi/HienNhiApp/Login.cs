using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HienNhiDTOs;
using HienNhiBLL;
using System.Data.SqlClient;
using System.IO;
using System.Xml;
using MyExceptionNS;

namespace HienNhiApp
{
    public partial class Login : Form
    {
        private BLL myBLL;
        
        public Login()
        {
            InitializeComponent();
            myBLL = new BLL();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Chưa nhập Username!!!");
                    txtUsername.Focus();
                }

                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Chưa nhập password!!!");
                    txtPassword.Focus();
                }

                Program.role = myBLL.verifyLogin(txtUsername.Text, txtPassword.Text);

                if (Program.role == 0)
                {
                    MessageBox.Show("Username hoặc password không đúng. Vui lòng kiểm tra lại.");
                    txtUsername.Focus();
                }
                else
                {
                    frmMain mainForm = new frmMain();
                    mainForm.Show();
                    //this.Close();
                }



            }
            catch (MyException ex)
            {

                CommonFunction.writeLog(ex);
               
            }
            catch (Exception ex1)
            {
                MyException myEx = new MyException();
                myEx.className = this.GetType().Name;
                myEx.errMsg = ex1.Message;
                CommonFunction.writeLog(myEx);
                MessageBox.Show(ex1.Message);
                
            }

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Application.
            this.Dispose();

        }
    }
}
