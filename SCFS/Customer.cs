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
    public partial class Customer : Form
    {
        private StallDatabase stallDatabase;
        private OrderDatabase orderDatabase;
        private CustomerAccount account;
        private Order myOrder;
        private bool reOrder;
        private int orderID;
        public Customer(CustomerAccount account, StallDatabase stallDatabase, OrderDatabase orderDatabase)
        {
            InitializeComponent();
            this.stallDatabase = stallDatabase;
            this.orderDatabase = orderDatabase;
            this.account = account;
            this.reOrder = false;
            this.orderID = orderDatabase.getCount() + 1;
            myOrder = new Order(orderID, account.getName());
            lblCustomerName.Text = account.getName();
            for(int i = 0; i < stallDatabase.getCount(); i++)
            {
                string[] arr = new string[2];
                arr[0] = stallDatabase.getStall(i).getID().ToString();
                arr[1] = stallDatabase.getStall(i).getName();
                ListViewItem l1 = new ListViewItem(arr);
                vbStallSelect.Items.Add(l1);
                cbStall.Items.Add(stallDatabase.getStall(i).getName());
            }

            //Stall select
            lbStall.Hide();
            lbl1.Hide();
            lbl2.Hide();
            vbStallSelect.Hide();
            cbStall.Hide();
            btnSearch.Hide();
            //Order
            lbOrder.Hide();
            lbl3.Hide();
            lbl4.Hide();
            lbl5.Hide();
            lbl6.Hide();
            lblNotification.Hide();
            lblNotification.Text = "";
            lblNoFood.Hide();
            vbCheckOrder.Hide();
            vbOrderView.Hide();
            cbAmount.Hide();
            cbFood.Hide();
            btnAddFood.Hide();
            btnRemoveFood.Hide();
            btnOrder.Hide();
            btnNewOrder.Hide();
            //State
            lbl7.Hide();
            lbl8.Hide();
            lblState.Hide();
            lblState.Text = "";
            lbOrderState.Hide();
            vbOrderState.Hide();

            lbl11.Hide();
            lbl12.Hide();
            cbOrderList.Hide();
            btnViewState.Hide();
            vbOrderID.Hide();
            //Bill
            lbl10.Hide();
            vbBillView.Hide();
            lblMoney.Hide();
            lblMoney.Text = "";
            btnViewBill.Hide();
            lbl13.Hide();
            lblPay.Hide();
            lblPay.Text = "";
            btnPay.Hide();
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if(cbFood.Text != "")
            {
                Food selectFood = stallDatabase.searchStall(cbStall.Text).getFood(cbFood.Text);
                order(selectFood, stallDatabase.searchStall(cbStall.Text), (int)cbAmount.Value);
                cbFood.Text = "";
                cbAmount.Value = 1;
            }
        }

        private void btnRemoveFood_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vbCheckOrder.Items.Count; i++)
            {
                if (vbCheckOrder.Items[i].Selected)
                {
                    vbCheckOrder.Items[i].Remove();
                    myOrder.removeFood(i);
                    i--;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            //Stall select
            lbStall.Show();
            lbl1.Show();
            lbl2.Show();
            vbStallSelect.Show();
            cbStall.Show();
            btnSearch.Show();
            //Order
            lbOrder.Show();
            lbl3.Show();
            lbl4.Show();
            lbl5.Show();
            lbl6.Show();
            lblNotification.Show();
            lblNotification.Text = "";
            vbCheckOrder.Show();
            vbOrderView.Show();
            cbAmount.Show();
            cbFood.Show();
            btnAddFood.Show();
            btnRemoveFood.Show();
            btnOrder.Show();
            btnNewOrder.Show();
            //State
            lbl7.Hide();
            lbl8.Hide();
            lblState.Hide();
            lblState.Text = "";
            lbOrderState.Hide();
            vbOrderState.Hide();
            lbl11.Hide();
            lbl12.Hide();
            cbOrderList.Hide();
            btnViewState.Hide();
            vbOrderID.Hide();
            //Bill
            lbl10.Hide();
            vbBillView.Hide();
            lblMoney.Hide();
            lblMoney.Text = "";
            btnViewBill.Hide();
            lbl13.Hide();
            lblPay.Hide();
            lblPay.Text = "";
            btnPay.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbStall.Text != "")
            {
                vbOrderView.Items.Clear();
                cbFood.Items.Clear();
                Stall selectStall = stallDatabase.searchStall(cbStall.Text);
                if (selectStall.getFoodList().Count == 0) lblNoFood.Show();
                else lblNoFood.Hide();
                for (int i = 0; i < selectStall.getFoodList().Count; i++)
                {
                    string[] arr = new string[3];
                    arr[0] = selectStall.getFoodList().ElementAt<Food>(i).id.ToString();
                    arr[1] = selectStall.getFoodList().ElementAt<Food>(i).name;
                    arr[2] = selectStall.getFoodList().ElementAt<Food>(i).price.ToString();
                    ListViewItem l1 = new ListViewItem(arr);
                    vbOrderView.Items.Add(l1);
                    cbFood.Items.Add(selectStall.getFoodList().ElementAt<Food>(i).name);
                }
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            makeOrder();
        }

        public bool makeOrder()
        {
            if (vbCheckOrder.Items.Count == 0)
            {
                lblNotification.ForeColor = Color.Red;
                lblNotification.Text = "Không thể đặt một đơn hàng trống";
                return false;
            }
            else
            {
                if (!reOrder)
                {
                    lblNotification.ForeColor = Color.Green;
                    lblNotification.Text = "Đặt hành thành công";
                    orderDatabase.addOrder(myOrder);
                    reOrder = true;
                    return true;
                }
                else
                {
                    lblNotification.ForeColor = Color.Red;
                    lblNotification.Text = "Đơn hàng của bạn đã tồn tại.\nVui lòng tạo đơn hàng mới\nnếu bạn muốn thay đổi đơn hàng!";
                    return false;
                }
            }
        }
        public void order(Food food, Stall stall, int count)
        {
            string[] arr = new string[3];
            arr[0] = food.id.ToString();
            arr[1] = food.name;
            arr[2] = count.ToString();
            ListViewItem l1 = new ListViewItem(arr);
            vbCheckOrder.Items.Add(l1);
            myOrder.orderFood(food.id, stall.getID(), count, stallDatabase);
        }
        public String checkOrderState(int id)
        {
            Order order = orderDatabase.getOrder(id);
            if(order == null) return "Bạn không có đơn hàng nào cả!";
            switch (order.getState())
            {
                case State.WAITING:
                    return "Đang chờ để xử lý!";
                case State.DOING:
                    return "Đang được xử lý!";
                default:
                    return "Đã xong. Vui lòng \nđến quầy hàng để nhận hàng!";
            }
        }
        public int getCost(int id)
        {
            if (orderDatabase.getOrder(id) == null) return 0;
            return orderDatabase.getOrder(id).getCost();
        }

        private void btnOrderState_Click(object sender, EventArgs e)
        {
            //Stall select
            lbStall.Hide();
            lbl1.Hide();
            lbl2.Hide();
            vbStallSelect.Hide();
            cbStall.Hide();
            btnSearch.Hide();
            //Order
            lbOrder.Hide();
            lbl3.Hide();
            lbl4.Hide();
            lbl5.Hide();
            lbl6.Hide();
            lblNotification.Hide();
            lblNotification.Text = "";
            vbCheckOrder.Hide();
            vbOrderView.Hide();
            cbAmount.Hide();
            cbFood.Hide();
            btnAddFood.Hide();
            btnRemoveFood.Hide();
            btnOrder.Hide();
            btnNewOrder.Hide();
            //State
            lbl7.Show();
            lbl8.Show();
            lblState.Show();
            lblState.Text = "";
            lbOrderState.Show();
            vbOrderState.Show();
            lbl11.Show();
            lbl12.Show();
            cbOrderList.Show();
            cbOrderList.Text = "";
            btnViewState.Show();
            vbOrderID.Show();
            vbOrderState.Items.Clear();
            //Bill
            lbl10.Hide();
            vbBillView.Hide();
            lblMoney.Hide();
            lblMoney.Text = "";
            btnViewBill.Hide();
            lbl13.Hide();
            lblPay.Hide();
            lblPay.Text = "";
            btnPay.Hide();

            vbOrderID.Items.Clear();
            cbOrderList.Items.Clear();
            for (int i = 0; i < orderDatabase.getCount(); i++)
            {
                Order order = orderDatabase.getOrderList(i);
                if (order.getName() == account.getName())
                {
                    string[] arr = new string[1];
                    arr[0] = order.getID().ToString();
                    ListViewItem l1 = new ListViewItem(arr);
                    vbOrderID.Items.Add(l1);
                    cbOrderList.Items.Add(order.getID().ToString());
                }
            }
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            //Stall select
            lbStall.Hide();
            lbl1.Hide();
            lbl2.Hide();
            vbStallSelect.Hide();
            cbStall.Hide();
            btnSearch.Hide();
            //Order
            lbOrder.Hide();
            lbl3.Hide();
            lbl4.Hide();
            lbl5.Hide();
            lbl6.Hide();
            lblNotification.Hide();
            lblNotification.Text = "";
            vbCheckOrder.Hide();
            vbOrderView.Hide();
            cbAmount.Hide();
            cbFood.Hide();
            btnAddFood.Hide();
            btnRemoveFood.Hide();
            btnOrder.Hide();
            btnNewOrder.Hide();
            //State
            lbl7.Hide();
            lbl8.Hide();
            lblState.Hide();
            lblState.Text = "";
            lbOrderState.Hide();
            vbOrderState.Hide();
            lbl11.Show();
            lbl12.Show();
            cbOrderList.Show();
            cbOrderList.Text = "";
            btnViewState.Hide();
            vbOrderID.Show();
            //Bill
            lbl10.Show();
            vbBillView.Show();
            lblMoney.Show();
            lblMoney.Text = "";
            lbOrderState.Show();
            btnViewBill.Show();
            lbl13.Show();
            lblPay.Show();
            lblPay.Text = "";
            btnPay.Hide();
            vbBillView.Items.Clear();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            reOrder = false;
            myOrder = new Order(++orderID, account.getName());
            vbCheckOrder.Items.Clear();
            vbOrderView.Items.Clear();
            cbAmount.Value = 1;
            cbFood.Text = "";
            cbStall.Text = "";
        }

        private void btnViewState_Click(object sender, EventArgs e)
        {
            if (cbOrderList.Text != "")
            {
                vbOrderState.Items.Clear();
                Order order = orderDatabase.getOrder((int)Double.Parse(cbOrderList.Text));
                for (int i = 0; i < order.getFoodList().Count; i++)
                {
                    Food food = order.getFoodList().ElementAt<Food>(i);
                    string[] arr = new string[3];
                    arr[0] = food.id.ToString();
                    arr[1] = food.name;
                    arr[2] = food.amount.ToString();
                    ListViewItem l1 = new ListViewItem(arr);
                    vbOrderState.Items.Add(l1);
                }
                lblState.Text = checkOrderState(order.getID());
            }
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            if (cbOrderList.Text != "")
            {
                vbBillView.Items.Clear();
                Order order = orderDatabase.getOrder((int)Double.Parse(cbOrderList.Text));
                for (int i = 0; i < order.getFoodList().Count; i++)
                {
                    Food food = order.getFoodList().ElementAt<Food>(i);
                    string[] arr = new string[5];
                    arr[0] = food.id.ToString();
                    arr[1] = food.name;
                    arr[2] = food.price.ToString();
                    arr[3] = food.amount.ToString();
                    arr[4] = (food.price * food.amount).ToString();
                    ListViewItem l1 = new ListViewItem(arr);
                    vbBillView.Items.Add(l1);
                }
                lblMoney.Text = getCost((int)Double.Parse(cbOrderList.Text)).ToString();
                btnPay.Show();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (orderDatabase.getOrder((int)Double.Parse(cbOrderList.Text)).getState() != State.READY)
            {
                lblPay.ForeColor = Color.Red;
                lblPay.Text = "Chỉ có thể thanh toán khi đơn hàng đã hoàn thành.\nVui lòng theo dõi trạng thái đơn hàng!";
            }
            else
            {
                orderDatabase.removeOrder((int)Double.Parse(cbOrderList.Text));
                vbBillView.Items.Clear();
                lblMoney.Text = "";
                vbOrderID.Items.Clear();
                cbOrderList.Items.Clear();
                cbOrderList.Text = "";
                lblPay.ForeColor = Color.Green;
                lblPay.Text = "Yêu cầu thanh toán đã được gửi.\nVui lòng đến cửa hàng để tiến hành thanh toán.";
                for (int i = 0; i < orderDatabase.getCount(); i++)
                {
                    Order order = orderDatabase.getOrderList(i);
                    string[] arr = new string[1];
                    arr[0] = order.getID().ToString();
                    ListViewItem l1 = new ListViewItem(arr);
                    vbOrderID.Items.Add(l1);
                    cbOrderList.Items.Add(order.getID().ToString());
                }
                btnPay.Hide();
            }
        }
    }
}
