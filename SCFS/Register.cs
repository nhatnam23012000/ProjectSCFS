using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFCS
{
    public partial class Register : Form
    {
        public bool success = false;
        private AccountDatabase accountDatabase;
        public Register(AccountDatabase accountDatabase)
        {
            InitializeComponent();
            this.accountDatabase = accountDatabase;
            lblNotification.Text = "";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                lblNotification.ForeColor = Color.Red;
                lblNotification.Text = "Vui lòng nhập tên đăng nhập!";
            }
            else
            {
                if (txtPass.Text == "")
                {
                    lblNotification.ForeColor = Color.Red;
                    lblNotification.Text = "Vui lòng nhập mật khẩu!";
                }
                else
                {
                    if (txtcheckPass.Text == txtPass.Text)
                    {
                        if (accountDatabase.addCustomerAccount(txtName.Text, txtPass.Text))
                        {
                            success = true;
                            this.Close();
                        }
                        else
                        {
                            lblNotification.ForeColor = Color.Red;
                            lblNotification.Text = "Tên đăng nhập đã tồn tại!";
                        }
                    }
                    else
                    {
                        lblNotification.ForeColor = Color.Red;
                        lblNotification.Text = "Mật khẩu xác nhận không đúng!";
                    }
                }
            }            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
