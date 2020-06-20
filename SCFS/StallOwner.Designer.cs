namespace SFCS
{
    partial class StallOwner
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
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnStallInfo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddFoodNotification = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblStallName = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblStallID = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.vbFoodList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vbReport = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(262, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 48);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Đăng xuất";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblName.Location = new System.Drawing.Point(99, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 20);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "StallOwner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Welcome, ";
            // 
            // btnViewReport
            // 
            this.btnViewReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewReport.Location = new System.Drawing.Point(262, 77);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(117, 48);
            this.btnViewReport.TabIndex = 21;
            this.btnViewReport.Text = "Xem báo cáo doanh thu";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFood.Location = new System.Drawing.Point(16, 77);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(117, 48);
            this.btnAddFood.TabIndex = 22;
            this.btnAddFood.Text = "Thêm món ăn vào thực đơn";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnStallInfo
            // 
            this.btnStallInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStallInfo.Location = new System.Drawing.Point(139, 77);
            this.btnStallInfo.Name = "btnStallInfo";
            this.btnStallInfo.Size = new System.Drawing.Size(117, 48);
            this.btnStallInfo.TabIndex = 23;
            this.btnStallInfo.Text = "Xem thông tin cửa hàng";
            this.btnStallInfo.UseVisualStyleBackColor = true;
            this.btnStallInfo.Click += new System.EventHandler(this.btnStallInfo_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(363, 292);
            this.listBox1.TabIndex = 24;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(171, 225);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(175, 22);
            this.txtCost.TabIndex = 30;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(29, 228);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(92, 17);
            this.lbl3.TabIndex = 29;
            this.lbl3.Text = "Nhập giá tiền";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(171, 187);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(175, 22);
            this.txtFoodName.TabIndex = 28;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(29, 190);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(117, 17);
            this.lbl2.TabIndex = 27;
            this.lbl2.Text = "Nhập tên món ăn";
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(171, 150);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(175, 22);
            this.txtFoodID.TabIndex = 26;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(29, 153);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(116, 17);
            this.lbl1.TabIndex = 25;
            this.lbl1.Text = "Nhập mã món ăn";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(171, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddFoodNotification
            // 
            this.lblAddFoodNotification.AutoSize = true;
            this.lblAddFoodNotification.BackColor = System.Drawing.Color.White;
            this.lblAddFoodNotification.Location = new System.Drawing.Point(100, 304);
            this.lblAddFoodNotification.Name = "lblAddFoodNotification";
            this.lblAddFoodNotification.Size = new System.Drawing.Size(78, 17);
            this.lblAddFoodNotification.TabIndex = 32;
            this.lblAddFoodNotification.Text = "Notification";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(30, 153);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(104, 17);
            this.lbl4.TabIndex = 34;
            this.lbl4.Text = "Tên quầy hàng";
            // 
            // lblStallName
            // 
            this.lblStallName.AutoSize = true;
            this.lblStallName.BackColor = System.Drawing.Color.White;
            this.lblStallName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStallName.Location = new System.Drawing.Point(168, 153);
            this.lblStallName.Name = "lblStallName";
            this.lblStallName.Size = new System.Drawing.Size(49, 17);
            this.lblStallName.TabIndex = 35;
            this.lblStallName.Text = "Name";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(30, 190);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(98, 17);
            this.lbl5.TabIndex = 36;
            this.lbl5.Text = "Mã quầy hàng";
            // 
            // lblStallID
            // 
            this.lblStallID.AutoSize = true;
            this.lblStallID.BackColor = System.Drawing.Color.White;
            this.lblStallID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStallID.Location = new System.Drawing.Point(168, 190);
            this.lblStallID.Name = "lblStallID";
            this.lblStallID.Size = new System.Drawing.Size(23, 17);
            this.lblStallID.TabIndex = 37;
            this.lblStallID.Text = "ID";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.White;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(29, 228);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(143, 17);
            this.lbl6.TabIndex = 38;
            this.lbl6.Text = "Danh sách món ăn";
            // 
            // vbFoodList
            // 
            this.vbFoodList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.vbFoodList.HideSelection = false;
            this.vbFoodList.Location = new System.Drawing.Point(33, 248);
            this.vbFoodList.Name = "vbFoodList";
            this.vbFoodList.Size = new System.Drawing.Size(326, 160);
            this.vbFoodList.TabIndex = 39;
            this.vbFoodList.UseCompatibleStateImageBehavior = false;
            this.vbFoodList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã món ăn";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên món ăn";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá tiền";
            this.columnHeader3.Width = 100;
            // 
            // vbReport
            // 
            this.vbReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.vbReport.HideSelection = false;
            this.vbReport.Location = new System.Drawing.Point(32, 150);
            this.vbReport.Name = "vbReport";
            this.vbReport.Size = new System.Drawing.Size(326, 258);
            this.vbReport.TabIndex = 40;
            this.vbReport.UseCompatibleStateImageBehavior = false;
            this.vbReport.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã báo cáo";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tiền thu";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tiền chi";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Lợi nhuận";
            // 
            // StallOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(393, 452);
            this.Controls.Add(this.vbReport);
            this.Controls.Add(this.vbFoodList);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lblStallID);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lblStallName);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lblAddFoodNotification);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtFoodID);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnStallInfo);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StallOwner";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnStallInfo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddFoodNotification;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblStallName;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblStallID;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.ListView vbFoodList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView vbReport;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}