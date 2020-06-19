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
    public partial class Login : Form
    {
        private AccountDatabase accountDatabase;
        private StallDatabase stallDatabase;
        private OrderDatabase orderDatabase;
        private ReportDatabase reportDatabase;
        public Login(AccountDatabase accountDatabase, StallDatabase stallDatabase, OrderDatabase orderDatabase, ReportDatabase reportDatabase)
        {
            InitializeComponent();
            this.accountDatabase = accountDatabase;
            this.stallDatabase = stallDatabase;
            this.orderDatabase = orderDatabase;
            this.reportDatabase = reportDatabase;
            lblNotification.Text = "";
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            login(txtName.Text, txtPass.Text);            
        }

        private void lbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register(accountDatabase);
        }

        public void login(String name, String pass)
        {
            if (accountDatabase.checkInfo(name, pass))
            {
                switch (accountDatabase.getAuthorization(name))
                {
                    case Authorization.CUSTOMER:
                        Customer f3 = new Customer((CustomerAccount)accountDatabase.getAccount(name), stallDatabase, orderDatabase);
                        this.Hide();
                        f3.ShowDialog();
                        txtName.Text = "";
                        txtPass.Text = "";
                        lblNotification.Text = "";
                        this.Show();
                        break;
                    case Authorization.ITSTAFF:
                    case Authorization.MASTERITSTAFF:
                        ITStaff f4 = new ITStaff((StaffAccount)accountDatabase.getAccount(name), accountDatabase, stallDatabase);
                        this.Hide();
                        f4.ShowDialog();
                        txtName.Text = "";
                        txtPass.Text = "";
                        lblNotification.Text = "";
                        this.Show();
                        if (f4.maintenance)
                        {
                            this.Close();
                        }
                        break;
                    case Authorization.COOK:
                        Cook f5 = new Cook((StaffAccount)accountDatabase.getAccount(name) , orderDatabase);
                        this.Hide();
                        f5.ShowDialog();
                        txtName.Text = "";
                        txtPass.Text = "";
                        lblNotification.Text = "";
                        this.Show();
                        break;
                }
            }
            else
            {
                lblNotification.ForeColor = Color.Red;
                lblNotification.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
            }
        }
        public void register(AccountDatabase accountDatabase)
        {
            Register f2 = new Register(accountDatabase);
            this.Hide();
            f2.ShowDialog();
            this.Show();
            txtName.Text = "";
            txtPass.Text = "";
            lblNotification.Text = "";
            if (f2.success)
            {
                lblNotification.ForeColor = Color.Green;
                lblNotification.Text = "Đăng ký tài khoản thành công!";
            }
        }
    }
}
