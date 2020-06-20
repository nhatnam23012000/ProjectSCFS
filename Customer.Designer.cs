namespace SFCS
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.lbMain = new System.Windows.Forms.ListBox();
            this.btnOrderState = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.vbStallSelect = new System.Windows.Forms.ListView();
            this.StallID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StallName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl1 = new System.Windows.Forms.Label();
            this.cbStall = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbStall = new System.Windows.Forms.ListBox();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.vbOrderView = new System.Windows.Forms.ListView();
            this.foodID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foodPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl4 = new System.Windows.Forms.Label();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbAmount = new System.Windows.Forms.NumericUpDown();
            this.lbl5 = new System.Windows.Forms.Label();
            this.vbCheckOrder = new System.Windows.Forms.ListView();
            this.foodCheckID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foodCheckName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foodCheckNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnRemoveFood = new System.Windows.Forms.Button();
            this.lbl6 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblNotification = new System.Windows.Forms.Label();
            this.lblNoFood = new System.Windows.Forms.Label();
            this.lbOrderState = new System.Windows.Forms.ListBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.vbOrderState = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl8 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.vbBillView = new System.Windows.Forms.ListView();
            this.IDOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl10 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.lbl11 = new System.Windows.Forms.Label();
            this.vbOrderID = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl12 = new System.Windows.Forms.Label();
            this.cbOrderList = new System.Windows.Forms.ComboBox();
            this.btnViewState = new System.Windows.Forms.Button();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.lbl13 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblPay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cbAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(372, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 51);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Đăng xuất";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, ";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCustomerName.Location = new System.Drawing.Point(106, 12);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(59, 20);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Guest";
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeOrder.Location = new System.Drawing.Point(18, 75);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(136, 33);
            this.btnMakeOrder.TabIndex = 3;
            this.btnMakeOrder.Text = "Đặt hàng";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // lbMain
            // 
            this.lbMain.FormattingEnabled = true;
            this.lbMain.ItemHeight = 16;
            this.lbMain.Location = new System.Drawing.Point(18, 114);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(472, 692);
            this.lbMain.TabIndex = 4;
            // 
            // btnOrderState
            // 
            this.btnOrderState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderState.Location = new System.Drawing.Point(160, 75);
            this.btnOrderState.Name = "btnOrderState";
            this.btnOrderState.Size = new System.Drawing.Size(189, 33);
            this.btnOrderState.TabIndex = 5;
            this.btnOrderState.Text = "Xem trạng thái đơn hàng";
            this.btnOrderState.UseVisualStyleBackColor = true;
            this.btnOrderState.Click += new System.EventHandler(this.btnOrderState_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewOrder.Location = new System.Drawing.Point(355, 75);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(135, 33);
            this.btnViewOrder.TabIndex = 6;
            this.btnViewOrder.Text = "Xem hóa đơn";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(47, 309);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(112, 17);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Chọn quầy hàng";
            // 
            // vbStallSelect
            // 
            this.vbStallSelect.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StallID,
            this.StallName});
            this.vbStallSelect.HideSelection = false;
            this.vbStallSelect.Location = new System.Drawing.Point(50, 159);
            this.vbStallSelect.Name = "vbStallSelect";
            this.vbStallSelect.Size = new System.Drawing.Size(411, 127);
            this.vbStallSelect.TabIndex = 9;
            this.vbStallSelect.UseCompatibleStateImageBehavior = false;
            this.vbStallSelect.View = System.Windows.Forms.View.Details;
            // 
            // StallID
            // 
            this.StallID.Tag = "";
            this.StallID.Text = "Mã quầy hàng";
            this.StallID.Width = 150;
            // 
            // StallName
            // 
            this.StallName.Tag = "";
            this.StallName.Text = "Tên quầy hàng";
            this.StallName.Width = 150;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(47, 139);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(166, 17);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "Danh sách quầy hàng";
            // 
            // cbStall
            // 
            this.cbStall.FormattingEnabled = true;
            this.cbStall.Location = new System.Drawing.Point(190, 306);
            this.cbStall.Name = "cbStall";
            this.cbStall.Size = new System.Drawing.Size(172, 24);
            this.cbStall.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(372, 292);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 45);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Tìm thực đơn";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(47, 372);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(76, 17);
            this.lbl3.TabIndex = 13;
            this.lbl3.Text = "Thực đơn";
            // 
            // lbStall
            // 
            this.lbStall.FormattingEnabled = true;
            this.lbStall.ItemHeight = 16;
            this.lbStall.Location = new System.Drawing.Point(34, 130);
            this.lbStall.Name = "lbStall";
            this.lbStall.Size = new System.Drawing.Size(439, 212);
            this.lbStall.TabIndex = 14;
            // 
            // lbOrder
            // 
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.ItemHeight = 16;
            this.lbOrder.Location = new System.Drawing.Point(34, 359);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(439, 436);
            this.lbOrder.TabIndex = 15;
            // 
            // vbOrderView
            // 
            this.vbOrderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.foodID,
            this.foodName,
            this.foodPrice});
            this.vbOrderView.HideSelection = false;
            this.vbOrderView.Location = new System.Drawing.Point(50, 392);
            this.vbOrderView.Name = "vbOrderView";
            this.vbOrderView.Size = new System.Drawing.Size(411, 125);
            this.vbOrderView.TabIndex = 16;
            this.vbOrderView.UseCompatibleStateImageBehavior = false;
            this.vbOrderView.View = System.Windows.Forms.View.Details;
            // 
            // foodID
            // 
            this.foodID.Tag = "";
            this.foodID.Text = "Mã món ăn";
            this.foodID.Width = 100;
            // 
            // foodName
            // 
            this.foodName.Tag = "";
            this.foodName.Text = "Tên món ăn";
            this.foodName.Width = 150;
            // 
            // foodPrice
            // 
            this.foodPrice.Text = "Giá tiền";
            this.foodPrice.Width = 100;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(47, 526);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(92, 17);
            this.lbl4.TabIndex = 20;
            this.lbl4.Text = "Chọn món ăn";
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(145, 523);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(141, 24);
            this.cbFood.TabIndex = 21;
            // 
            // cbAmount
            // 
            this.cbAmount.Location = new System.Drawing.Point(368, 524);
            this.cbAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cbAmount.Name = "cbAmount";
            this.cbAmount.Size = new System.Drawing.Size(38, 22);
            this.cbAmount.TabIndex = 22;
            this.cbAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(298, 526);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(64, 17);
            this.lbl5.TabIndex = 23;
            this.lbl5.Text = "Số lượng";
            // 
            // vbCheckOrder
            // 
            this.vbCheckOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.foodCheckID,
            this.foodCheckName,
            this.foodCheckNum});
            this.vbCheckOrder.HideSelection = false;
            this.vbCheckOrder.Location = new System.Drawing.Point(50, 576);
            this.vbCheckOrder.Name = "vbCheckOrder";
            this.vbCheckOrder.Size = new System.Drawing.Size(347, 119);
            this.vbCheckOrder.TabIndex = 24;
            this.vbCheckOrder.UseCompatibleStateImageBehavior = false;
            this.vbCheckOrder.View = System.Windows.Forms.View.Details;
            // 
            // foodCheckID
            // 
            this.foodCheckID.Tag = "";
            this.foodCheckID.Text = "Mã món ăn";
            this.foodCheckID.Width = 100;
            // 
            // foodCheckName
            // 
            this.foodCheckName.Tag = "";
            this.foodCheckName.Text = "Tên món ăn";
            this.foodCheckName.Width = 100;
            // 
            // foodCheckNum
            // 
            this.foodCheckNum.Text = "Số lượng";
            this.foodCheckNum.Width = 80;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFood.Location = new System.Drawing.Point(403, 576);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(58, 36);
            this.btnAddFood.TabIndex = 25;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnRemoveFood
            // 
            this.btnRemoveFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveFood.Location = new System.Drawing.Point(403, 618);
            this.btnRemoveFood.Name = "btnRemoveFood";
            this.btnRemoveFood.Size = new System.Drawing.Size(58, 36);
            this.btnRemoveFood.TabIndex = 26;
            this.btnRemoveFood.Text = "Xóa";
            this.btnRemoveFood.UseVisualStyleBackColor = true;
            this.btnRemoveFood.Click += new System.EventHandler(this.btnRemoveFood_Click);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.White;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(47, 556);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(146, 17);
            this.lbl6.TabIndex = 27;
            this.lbl6.Text = "Thông tin đặt hàng";
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Location = new System.Drawing.Point(50, 701);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(108, 36);
            this.btnOrder.TabIndex = 28;
            this.btnOrder.Text = "Đặt hàng";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.BackColor = System.Drawing.Color.White;
            this.lblNotification.Location = new System.Drawing.Point(212, 711);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(46, 17);
            this.lblNotification.TabIndex = 30;
            this.lblNotification.Text = "label1";
            // 
            // lblNoFood
            // 
            this.lblNoFood.AutoSize = true;
            this.lblNoFood.BackColor = System.Drawing.Color.White;
            this.lblNoFood.ForeColor = System.Drawing.Color.Red;
            this.lblNoFood.Location = new System.Drawing.Point(132, 372);
            this.lblNoFood.Name = "lblNoFood";
            this.lblNoFood.Size = new System.Drawing.Size(185, 17);
            this.lblNoFood.TabIndex = 31;
            this.lblNoFood.Text = "There is no food in this stall!";
            // 
            // lbOrderState
            // 
            this.lbOrderState.FormattingEnabled = true;
            this.lbOrderState.ItemHeight = 16;
            this.lbOrderState.Location = new System.Drawing.Point(34, 130);
            this.lbOrderState.Name = "lbOrderState";
            this.lbOrderState.Size = new System.Drawing.Size(439, 212);
            this.lbOrderState.TabIndex = 32;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.BackColor = System.Drawing.Color.White;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(47, 372);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(150, 17);
            this.lbl7.TabIndex = 34;
            this.lbl7.Text = "Thông tin đơn hàng";
            // 
            // vbOrderState
            // 
            this.vbOrderState.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.vbOrderState.HideSelection = false;
            this.vbOrderState.Location = new System.Drawing.Point(50, 392);
            this.vbOrderState.Name = "vbOrderState";
            this.vbOrderState.Size = new System.Drawing.Size(411, 119);
            this.vbOrderState.TabIndex = 33;
            this.vbOrderState.UseCompatibleStateImageBehavior = false;
            this.vbOrderState.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "Mã món ăn";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "";
            this.columnHeader2.Text = "Tên món ăn";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 80;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.Color.White;
            this.lbl8.Location = new System.Drawing.Point(47, 525);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(141, 17);
            this.lbl8.TabIndex = 35;
            this.lbl8.Text = "Trạng thái đơn hàng:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.White;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Black;
            this.lblState.Location = new System.Drawing.Point(194, 525);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(44, 17);
            this.lblState.TabIndex = 36;
            this.lblState.Text = "state";
            // 
            // vbBillView
            // 
            this.vbBillView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDOrder,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.vbBillView.HideSelection = false;
            this.vbBillView.Location = new System.Drawing.Point(50, 393);
            this.vbBillView.Name = "vbBillView";
            this.vbBillView.Size = new System.Drawing.Size(411, 125);
            this.vbBillView.TabIndex = 38;
            this.vbBillView.UseCompatibleStateImageBehavior = false;
            this.vbBillView.View = System.Windows.Forms.View.Details;
            // 
            // IDOrder
            // 
            this.IDOrder.Tag = "";
            this.IDOrder.Text = "Mã món ăn";
            this.IDOrder.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Tag = "";
            this.columnHeader5.Text = "Tên món ăn";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giá tiền";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số lượng";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Thành tiền";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.BackColor = System.Drawing.Color.White;
            this.lbl10.Location = new System.Drawing.Point(258, 530);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(72, 17);
            this.lbl10.TabIndex = 39;
            this.lbl10.Text = "Tổng tiền:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.White;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(336, 523);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(26, 29);
            this.lblMoney.TabIndex = 40;
            this.lblMoney.Text = "0";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewOrder.Location = new System.Drawing.Point(50, 743);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(144, 33);
            this.btnNewOrder.TabIndex = 41;
            this.btnNewOrder.Text = "Tạo đơn hàng mới";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.BackColor = System.Drawing.Color.White;
            this.lbl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.Location = new System.Drawing.Point(47, 139);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(221, 17);
            this.lbl11.TabIndex = 42;
            this.lbl11.Text = "Danh sách đơn hàng của bạn";
            // 
            // vbOrderID
            // 
            this.vbOrderID.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id});
            this.vbOrderID.HideSelection = false;
            this.vbOrderID.Location = new System.Drawing.Point(50, 159);
            this.vbOrderID.Name = "vbOrderID";
            this.vbOrderID.Size = new System.Drawing.Size(138, 119);
            this.vbOrderID.TabIndex = 43;
            this.vbOrderID.UseCompatibleStateImageBehavior = false;
            this.vbOrderID.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Tag = "";
            this.id.Text = "Mã đơn hàng";
            this.id.Width = 100;
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.BackColor = System.Drawing.Color.White;
            this.lbl12.Location = new System.Drawing.Point(205, 168);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(105, 17);
            this.lbl12.TabIndex = 44;
            this.lbl12.Text = "Chọn đơn hàng";
            // 
            // cbOrderList
            // 
            this.cbOrderList.FormattingEnabled = true;
            this.cbOrderList.Location = new System.Drawing.Point(208, 188);
            this.cbOrderList.Name = "cbOrderList";
            this.cbOrderList.Size = new System.Drawing.Size(172, 24);
            this.cbOrderList.TabIndex = 45;
            // 
            // btnViewState
            // 
            this.btnViewState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewState.Location = new System.Drawing.Point(208, 218);
            this.btnViewState.Name = "btnViewState";
            this.btnViewState.Size = new System.Drawing.Size(122, 48);
            this.btnViewState.TabIndex = 46;
            this.btnViewState.Text = "Xem trạng thái";
            this.btnViewState.UseVisualStyleBackColor = true;
            this.btnViewState.Click += new System.EventHandler(this.btnViewState_Click);
            // 
            // btnViewBill
            // 
            this.btnViewBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewBill.Location = new System.Drawing.Point(208, 218);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(122, 48);
            this.btnViewBill.TabIndex = 47;
            this.btnViewBill.Text = "Xem hóa đơn";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // lbl13
            // 
            this.lbl13.AutoSize = true;
            this.lbl13.BackColor = System.Drawing.Color.White;
            this.lbl13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl13.Location = new System.Drawing.Point(47, 373);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(141, 17);
            this.lbl13.TabIndex = 48;
            this.lbl13.Text = "Thông tin hóa đơn";
            // 
            // btnPay
            // 
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Location = new System.Drawing.Point(273, 565);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(107, 32);
            this.btnPay.TabIndex = 49;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.BackColor = System.Drawing.Color.White;
            this.lblPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPay.Location = new System.Drawing.Point(87, 605);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(67, 17);
            this.lblPay.TabIndex = 50;
            this.lblPay.Text = "Complete";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(505, 826);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lbl13);
            this.Controls.Add(this.btnViewBill);
            this.Controls.Add(this.btnViewState);
            this.Controls.Add(this.cbOrderList);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.vbOrderID);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.vbBillView);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.vbOrderState);
            this.Controls.Add(this.vbStallSelect);
            this.Controls.Add(this.vbCheckOrder);
            this.Controls.Add(this.vbOrderView);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lblNoFood);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.btnRemoveFood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.cbAmount);
            this.Controls.Add(this.cbFood);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbStall);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.btnOrderState);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbOrderState);
            this.Controls.Add(this.lbStall);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.lbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Home Page";
            ((System.ComponentModel.ISupportInitialize)(this.cbAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.ListBox lbMain;
        private System.Windows.Forms.Button btnOrderState;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ListView vbStallSelect;
        private System.Windows.Forms.ColumnHeader StallID;
        private System.Windows.Forms.ColumnHeader StallName;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cbStall;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ListBox lbStall;
        private System.Windows.Forms.ListBox lbOrder;
        private System.Windows.Forms.ListView vbOrderView;
        private System.Windows.Forms.ColumnHeader foodID;
        private System.Windows.Forms.ColumnHeader foodName;
        private System.Windows.Forms.ColumnHeader foodPrice;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.NumericUpDown cbAmount;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.ListView vbCheckOrder;
        private System.Windows.Forms.ColumnHeader foodCheckID;
        private System.Windows.Forms.ColumnHeader foodCheckName;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnRemoveFood;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.ColumnHeader foodCheckNum;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Label lblNoFood;
        private System.Windows.Forms.ListBox lbOrderState;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.ListView vbOrderState;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ListView vbBillView;
        private System.Windows.Forms.ColumnHeader IDOrder;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.ListView vbOrderID;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.ComboBox cbOrderList;
        private System.Windows.Forms.Button btnViewState;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblPay;
    }
}