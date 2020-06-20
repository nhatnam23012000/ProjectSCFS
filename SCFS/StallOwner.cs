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
    public partial class StallOwner : Form
    {
        private StallDatabase stallDatabase;
        private ReportDatabase reportDatabase;
        private StaffAccount account;
        private Stall myStall;
        public StallOwner(StaffAccount account, ReportDatabase reportDatabase, StallDatabase stallDatabase)
        {
            InitializeComponent();
            lblName.Text = account.getName();
            this.stallDatabase = stallDatabase;
            this.reportDatabase = reportDatabase;
            this.account = account;
            this.myStall = stallDatabase.getOwnerStall(account.getID());

            //Add food
            lbl1.Hide();
            lbl2.Hide();
            lbl3.Hide();
            txtFoodID.Hide();
            txtFoodName.Hide();
            txtCost.Hide();
            btnAdd.Hide();
            lblAddFoodNotification.Hide();
            lblAddFoodNotification.Text = "";

            //View food
            lbl4.Hide();
            lbl5.Hide();
            lbl6.Hide();
            lblStallID.Hide();
            lblStallName.Hide();
            vbFoodList.Hide();

            //View report
            vbReport.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            logout();
        }
        public void logout()
        {
            this.Close();
        }
        public void addFood(int id, String name, int cost)
        {
            stallDatabase.addFood(myStall.getID(), id, name, cost);
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            lbl1.Show();
            lbl2.Show();
            lbl3.Show();
            txtFoodID.Show();
            txtFoodName.Show();
            txtCost.Show();
            btnAdd.Show();
            lblAddFoodNotification.Show();
            lblAddFoodNotification.Text = "";

            //View food
            lbl4.Hide();
            lbl5.Hide();
            lbl6.Hide();
            lblStallID.Hide();
            lblStallName.Hide();
            vbFoodList.Hide();

            //View report
            vbReport.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtFoodID.Text == "")
            {
                lblAddFoodNotification.ForeColor = Color.Red;
                lblAddFoodNotification.Text = "Vui lòng nhập ID!";
            }
            else
            {
                if (txtFoodName.Text == "")
                {
                    lblAddFoodNotification.ForeColor = Color.Red;
                    lblAddFoodNotification.Text = "Vui lòng nhập tên!";
                }
                else
                {
                    if (txtCost.Text == "")
                    {
                        lblAddFoodNotification.ForeColor = Color.Red;
                        lblAddFoodNotification.Text = "Vui lòng nhập giá tiền!";
                    }
                    else
                    {
                        addFood((int)Double.Parse(txtFoodID.Text), txtFoodName.Text, (int)Double.Parse(txtCost.Text));
                        lblAddFoodNotification.ForeColor = Color.Green;
                        lblAddFoodNotification.Text = "Đã thêm món ăn vào thực đơn";
                    }
                }
            }
        }

        private void btnStallInfo_Click(object sender, EventArgs e)
        {
            //Add food
            lbl1.Hide();
            lbl2.Hide();
            lbl3.Hide();
            txtFoodID.Hide();
            txtFoodName.Hide();
            txtCost.Hide();
            btnAdd.Hide();
            lblAddFoodNotification.Hide();
            lblAddFoodNotification.Text = "";

            //View food
            lbl4.Show();
            lbl5.Show();
            lbl6.Show();
            lblStallID.Show();
            lblStallName.Show();
            vbFoodList.Show();

            //View report
            vbReport.Hide();

            vbFoodList.Items.Clear();
            lblStallID.Text = myStall.getID().ToString();
            lblStallName.Text = myStall.getName();
            for (int i = 0; i < myStall.getFoodList().Count; i++)
            {
                Food food = myStall.getFoodList().ElementAt<Food>(i);
                string[] arr = new string[3];
                arr[0] = food.id.ToString();
                arr[1] = food.name; ;
                arr[2] = food.price.ToString();
                ListViewItem l1 = new ListViewItem(arr);
                vbFoodList.Items.Add(l1);
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            //Add food
            lbl1.Hide();
            lbl2.Hide();
            lbl3.Hide();
            txtFoodID.Hide();
            txtFoodName.Hide();
            txtCost.Hide();
            btnAdd.Hide();
            lblAddFoodNotification.Hide();
            lblAddFoodNotification.Text = "";

            //View food
            lbl4.Hide();
            lbl5.Hide();
            lbl6.Hide();
            lblStallID.Hide();
            lblStallName.Hide();
            vbFoodList.Hide();

            //View report
            vbReport.Show();

            for(int i = 0; i < reportDatabase.getCount(); i++)
            {
                Report report = reportDatabase.getReport(i);
                if(report.getOwner() == myStall.getName())
                {
                    string[] arr = new string[5];
                    arr[0] = report.getID().ToString();
                    arr[1] = report.getData().dateCreate;
                    arr[2] = report.getData().income.ToString();
                    arr[3] = report.getData().outcome.ToString();
                    arr[4] = report.getData().profit.ToString();
                    ListViewItem l1 = new ListViewItem(arr);
                    vbReport.Items.Add(l1);
                }
            }

        }
    }
}
