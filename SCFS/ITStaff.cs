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
    public partial class ITStaff : Form
    {
        public bool maintenance;
        private AccountDatabase accountDatabase;
        private StaffAccount account;
        private StallDatabase stallDatabase;
        public ITStaff(StaffAccount account, AccountDatabase accountDatabase, StallDatabase stallDatabase)
        {
            InitializeComponent();
            this.accountDatabase = accountDatabase;
            this.account = account;      
            this.stallDatabase = stallDatabase;
            lbName.Text = account.getName();
            //Maintenance Mode
            btnMaintenanceOK.Hide();
            btnMaintenanceCancel.Hide();
            lbMaintenance.Hide();
            lblMaintenanceFailed.Text = "";
            //Add Account for Staff
            lblAccName.Hide();
            lblAccPass.Hide();
            lblAccPassCheck.Hide();
            lblAddAccNoti.Hide();            
            txtStaffName.Hide();
            txtStaffPass.Hide();
            txtStaffPassCheck.Hide();
            btnAddAccount.Hide();
            btnAccCancel.Hide();
            lblAuthorization.Hide();
            cbAuthorization.Hide();
            lblAccID.Hide();
            txtAccID.Hide();
            lblAddAccNoti.Text = "";
            //Add/RemoveStall
            btnAddStall.Hide();
            btnRemoveStall.Hide();
            lblStallID.Hide();
            lblStallName.Hide();
            txtStallID.Hide();
            txtStallName.Hide();
            btnAddStallCmd.Hide();
            lsEditStall.Hide();
            btnAddStallCancel.Hide();
            btnRemoveStallCmd.Hide();
            btnRemoveStallCancel.Hide();
            lblRemoveNotification.Hide();
            lblRemoveNotification.Text = "";
            btnRemoveCheck.Hide();
            lblAddNotification.Hide();
            lblAddNotification.Text = "";
            txtStallOwner.Hide();
            lbl1.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            logOut();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            lblAccName.Hide();
            lblAccPass.Hide();
            lblAccPassCheck.Hide();
            lblAddAccNoti.Hide();
            txtStaffName.Hide();
            txtStaffPass.Hide();
            txtStaffPassCheck.Hide();
            btnAddAccount.Hide();
            btnAccCancel.Hide();
            lblAuthorization.Hide();
            cbAuthorization.Hide();
            lblAccID.Hide();
            txtAccID.Hide();
            lblAddAccNoti.Text = "";
            btnAddStall.Hide();
            btnRemoveStall.Hide();
            lblStallID.Hide();
            lblStallName.Hide();
            txtStallID.Hide();
            txtStallName.Hide();
            btnAddStallCmd.Hide();
            lsEditStall.Hide();
            btnAddStallCancel.Hide();
            btnRemoveStallCmd.Hide();
            btnRemoveStallCancel.Hide();
            lblRemoveNotification.Hide();
            lblRemoveNotification.Text = "";
            btnRemoveCheck.Hide();
            lblAddNotification.Hide();
            lblAddNotification.Text = "";
            txtStallOwner.Hide();
            lbl1.Hide();

            btnMaintenanceCancel.Show();
            btnMaintenanceOK.Show();
            lbMaintenance.Show();
            lblMaintenanceFailed.Show();
        }

        private void btnMaintenanceOK_Click(object sender, EventArgs e)
        {
            enableMaintenanceMode();
        }

        private void btnMaintenanceCancel_Click(object sender, EventArgs e)
        {
            btnMaintenanceCancel.Hide();
            btnMaintenanceOK.Hide();
            lbMaintenance.Hide();
            lblMaintenanceFailed.Hide();
            lblMaintenanceFailed.Text = "";

        }

        private void btnAddStaffAccount_Click(object sender, EventArgs e)
        {
            btnMaintenanceOK.Hide();
            btnMaintenanceCancel.Hide();
            lbMaintenance.Hide();
            lblMaintenanceFailed.Hide();
            lblMaintenanceFailed.Text = "";
            btnAddStall.Hide();
            btnRemoveStall.Hide();
            lblStallID.Hide();
            lblStallName.Hide();
            txtStallID.Hide();
            txtStallName.Hide();
            btnAddStallCmd.Hide();
            lsEditStall.Hide();
            btnAddStallCancel.Hide();
            btnRemoveStallCmd.Hide();
            btnRemoveStallCancel.Hide();
            lblRemoveNotification.Hide();
            lblRemoveNotification.Text = "";
            btnRemoveCheck.Hide();
            lblAddNotification.Hide();
            lblAddNotification.Text = "";
            txtStallOwner.Hide();
            lbl1.Hide();

            lblAccName.Show();
            lblAccPass.Show();
            lblAccPassCheck.Show();
            lblAddAccNoti.Show();
            txtStaffName.Show();
            txtStaffPass.Show();
            txtStaffPassCheck.Show();
            btnAddAccount.Show();
            btnAccCancel.Show();
            lblAuthorization.Show();
            cbAuthorization.Show();
            lblAccID.Show();
            txtAccID.Show();
        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            lblAccName.Hide();
            lblAccPass.Hide();
            lblAccPassCheck.Hide();
            lblAddAccNoti.Hide();
            txtStaffName.Hide();
            txtStaffPass.Hide();
            txtStaffPassCheck.Hide();
            btnAddAccount.Hide();
            btnAccCancel.Hide();
            lblAuthorization.Hide();
            cbAuthorization.Hide();
            lblAccID.Hide();
            txtAccID.Hide();

            lblAddAccNoti.Text = "";
            txtStaffName.Text = "";
            txtStaffPass.Text = "";
            txtStaffPassCheck.Text = "";
            cbAuthorization.Text = "";
            txtAccID.Text = "";
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (txtStaffName.Text == "")
            {
                lblAddAccNoti.ForeColor = Color.Red;
                lblAddAccNoti.Text = "Vui lòng nhập tên đăng nhập!";
            }
            else
            {
                if (txtStaffPass.Text == "")
                {
                    lblAddAccNoti.ForeColor = Color.Red;
                    lblAddAccNoti.Text = "Vui lòng nhập mật khẩu!";
                }
                else
                {
                    if (cbAuthorization.Text == "")
                    {
                        lblAddAccNoti.ForeColor = Color.Red;
                        lblAddAccNoti.Text = "Vui lòng chọn loại tài khoản";
                    }                    
                    else
                    {
                        if (txtAccID.Text == "")
                        {
                            lblAddAccNoti.ForeColor = Color.Red;
                            lblAddAccNoti.Text = "Vui lòng nhập ID!";
                        }
                        else
                        {
                            if (txtStaffPassCheck.Text == txtStaffPass.Text)
                            {
                                Authorization authorization = Authorization.COOK;
                                switch (cbAuthorization.Text)
                                {
                                    case "MANAGER":
                                        authorization = Authorization.MANAGER;
                                        break;
                                    case "COOK":
                                        authorization = Authorization.COOK;
                                        break;
                                    case "ITSTAFF":
                                        authorization = Authorization.ITSTAFF;
                                        break;
                                    case "STALLOWNER":
                                        authorization = Authorization.STALLOWNER;
                                        break;
                                }
                                createStaffAccount(txtStaffName.Text, txtStaffPass.Text, authorization, (int)Double.Parse(txtAccID.Text));
                            }
                            else
                            {
                                lblAddAccNoti.ForeColor = Color.Red;
                                lblAddAccNoti.Text = "Mật khẩu xác nhận không đúng!";
                            }
                        }
                    }                   
                }
            }
        }

        private void btnEditStallList_Click(object sender, EventArgs e)
        {
            lblStallID.Hide();
            lblStallName.Hide();
            txtStallID.Hide();
            txtStallName.Hide();
            btnAddStallCmd.Hide();
            btnAddStallCancel.Hide();
            btnRemoveStallCmd.Hide();
            btnRemoveStallCancel.Hide();
            lblRemoveNotification.Hide();
            lblRemoveNotification.Text = "";
            btnRemoveCheck.Hide();
            lblAddNotification.Hide();
            lblAddNotification.Text = "";
            txtStallOwner.Hide();
            lbl1.Hide();

            btnMaintenanceOK.Hide();
            btnMaintenanceCancel.Hide();
            lbMaintenance.Hide();
            lblAccName.Hide();
            lblAccPass.Hide();
            lblAccPassCheck.Hide();
            lblAddAccNoti.Hide();
            txtStaffName.Hide();
            txtStaffPass.Hide();
            txtStaffPassCheck.Hide();
            btnAddAccount.Hide();
            btnAccCancel.Hide();
            lblAuthorization.Hide();
            cbAuthorization.Hide();
            lblAccID.Hide();
            txtAccID.Hide();
            lblAddAccNoti.Text = "";
            lblMaintenanceFailed.Text = "";

            btnAddStall.Show();
            btnRemoveStall.Show();
            lsEditStall.Show();
        }

        private void btnAddStall_Click(object sender, EventArgs e)
        {
            lblStallID.Hide();
            txtStallID.Hide();
            btnRemoveStallCmd.Hide();
            btnRemoveStallCancel.Hide();            
            lblRemoveNotification.Text = "";
            txtStallID.Text = "";
            btnRemoveCheck.Hide();

            lblStallID.Show();
            lblStallName.Show();
            txtStallID.Show();
            txtStallName.Show();
            btnAddStallCmd.Show();
            lsEditStall.Show();
            btnAddStallCancel.Show();
            lblRemoveNotification.Show();
            lblAddNotification.Show();
            lblAddNotification.Text = "";
            txtStallOwner.Show();
            lbl1.Show();
        }

        private void btnAddStallCancel_Click(object sender, EventArgs e)
        {
            lblStallID.Hide();
            lblStallName.Hide();
            txtStallID.Hide();
            txtStallName.Hide();
            btnAddStallCmd.Hide();
            lsEditStall.Hide();
            btnAddStallCancel.Hide();
            lblRemoveNotification.Hide();
            lblAddNotification.Hide();

            lblAddNotification.Text = "";
            txtStallID.Text = "";
            txtStallName.Text = "";
            lblRemoveNotification.Text = "";
        }

        private void btnRemoveStall_Click(object sender, EventArgs e)
        {
            lblStallID.Hide();
            lblStallName.Hide();
            txtStallID.Hide();
            txtStallName.Hide();
            btnAddStallCmd.Hide();
            lsEditStall.Hide();
            btnAddStallCancel.Hide();
            txtStallID.Text = "";
            lblAddNotification.Hide();
            lblAddNotification.Text = "";
            txtStallOwner.Hide();
            lbl1.Hide();

            lblStallID.Show();
            txtStallID.Show();
            btnRemoveStallCmd.Show();
            btnRemoveStallCancel.Show();
            lblRemoveNotification.Show();
            btnRemoveCheck.Show();
            lblRemoveNotification.Text = "";

        }

        private void btnRemoveStallCancel_Click(object sender, EventArgs e)
        {
            lblStallID.Hide();
            txtStallID.Hide();
            btnRemoveStallCmd.Hide();
            btnRemoveStallCancel.Hide();
            lblRemoveNotification.Hide();
            btnRemoveCheck.Hide();

            lblRemoveNotification.Text = "";
            txtStallID.Text = "";
        }

        private void btnAddStallCmd_Click(object sender, EventArgs e)
        {
            if (txtStallID.Text == "")
            {
                lblAddNotification.ForeColor = Color.Red;
                lblAddNotification.Text = "Vui lòng nhập ID!";
            }
            else
            {
                if (txtStallName.Text == "")
                {
                    lblAddNotification.ForeColor = Color.Red;
                    lblAddNotification.Text = "Vui lòng nhập tên cửa hàng!";
                }
                else
                {
                    if (txtStallOwner.Text == "")
                    {
                        lblAddNotification.ForeColor = Color.Red;
                        lblAddNotification.Text = "Vui lòng nhập ID chủ cửa hàng!";
                    }
                    else
                    {
                        addStall((int)Double.Parse(txtStallID.Text), txtStallName.Text, (int)Double.Parse(txtStallOwner.Text));
                    }
                }
            }
        }

        private void btnRemoveStallCmd_Click(object sender, EventArgs e)
        {
            if (txtStallID.Text == "")
            {
                lblRemoveNotification.ForeColor = Color.Red;
                lblRemoveNotification.Text = "Vui lòng nhập ID!";
            }
            else
            {
                removeStall((int)Double.Parse(txtStallID.Text));                
            }
        }

        private void btnRemoveCheck_Click(object sender, EventArgs e)
        {
            if (txtStallID.Text == "")
            {
                lblRemoveNotification.ForeColor = Color.Red;
                lblRemoveNotification.Text = "Vui lòng nhập ID!";
            }
            else
            {
                if (stallDatabase.searchStall((int)Double.Parse(txtStallID.Text)) == null)
                {
                    lblRemoveNotification.ForeColor = Color.Red;
                    lblRemoveNotification.Text = "Cửa hàng không tồn tại!";
                }
                else
                {
                    lblRemoveNotification.ForeColor = Color.Black;
                    lblRemoveNotification.Text = "Bạn sắp xóa cửa hàng " + stallDatabase.searchStall((int)Double.Parse(txtStallID.Text)).getName() + ".\nBạn có thực sự muốn xóa cửa hàng này?";
                }
            }
        }

        public void enableMaintenanceMode()
        {
            if (accountDatabase.checkAuthorization(account.getID()))
            {
                maintenance = true;
                this.Close();
            }
            else
            {
                lblMaintenanceFailed.ForeColor = Color.Red;
                lblMaintenanceFailed.Text = "Tài khoản không đủ quyền hạn để thực hiện!";
            }
        }
        public void createStaffAccount(String name, String pass, Authorization authorization, int id)
        {
            if (accountDatabase.addStaffAccount(name, pass, authorization, id))
            {
                lblAddAccNoti.ForeColor = Color.Green;
                lblAddAccNoti.Text = "Tạo tài khoản thành công!";
            }
            else
            {
                lblAddAccNoti.ForeColor = Color.Red;
                lblAddAccNoti.Text = "Tên đăng nhập đã tồn tại!";
            }
        }
        public void addStall(int id, String name, int owner)
        {
            LinkedList<Food> foods = new LinkedList<Food>();
            if (stallDatabase.addStall(id, txtStallName.Text, foods, owner))
            {
                lblAddNotification.ForeColor = Color.Green;
                lblAddNotification.Text = "Tạo cửa hàng thành công!";
            }
            else
            {
                lblAddNotification.ForeColor = Color.Red;
                lblAddNotification.Text = "Tên cửa hàng đã tồn tại!";
            }
        }
        public void removeStall(int id)
        {
            if (stallDatabase.removeStall(id))
            {
                lblRemoveNotification.ForeColor = Color.Green;
                lblRemoveNotification.Text = "Xóa cửa hàng thành công!";
            }
            else
            {
                lblRemoveNotification.ForeColor = Color.Red;
                lblRemoveNotification.Text = "ID không tồn tại!";
            }
        }
        public void logOut()
        {
            this.Close();
        }
    }
}
