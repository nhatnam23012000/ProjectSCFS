namespace SFCS
{
    partial class ITStaff
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnMaintenanceOK = new System.Windows.Forms.Button();
            this.btnMaintenanceCancel = new System.Windows.Forms.Button();
            this.lbMaintenance = new System.Windows.Forms.Label();
            this.btnAddStaffAccount = new System.Windows.Forms.Button();
            this.btnEditStallList = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.lblAccName = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblAccPass = new System.Windows.Forms.Label();
            this.txtStaffPass = new System.Windows.Forms.TextBox();
            this.lblAccPassCheck = new System.Windows.Forms.Label();
            this.txtStaffPassCheck = new System.Windows.Forms.TextBox();
            this.lblAddAccNoti = new System.Windows.Forms.Label();
            this.btnAccCancel = new System.Windows.Forms.Button();
            this.cbAuthorization = new System.Windows.Forms.ComboBox();
            this.lblAuthorization = new System.Windows.Forms.Label();
            this.lblAccID = new System.Windows.Forms.Label();
            this.txtAccID = new System.Windows.Forms.TextBox();
            this.lblMaintenanceFailed = new System.Windows.Forms.Label();
            this.btnAddStall = new System.Windows.Forms.Button();
            this.btnRemoveStall = new System.Windows.Forms.Button();
            this.lsEditStall = new System.Windows.Forms.ListBox();
            this.lblStallID = new System.Windows.Forms.Label();
            this.lblStallName = new System.Windows.Forms.Label();
            this.txtStallID = new System.Windows.Forms.TextBox();
            this.txtStallName = new System.Windows.Forms.TextBox();
            this.btnAddStallCmd = new System.Windows.Forms.Button();
            this.btnAddStallCancel = new System.Windows.Forms.Button();
            this.btnRemoveStallCmd = new System.Windows.Forms.Button();
            this.btnRemoveStallCancel = new System.Windows.Forms.Button();
            this.lblRemoveNotification = new System.Windows.Forms.Label();
            this.btnRemoveCheck = new System.Windows.Forms.Button();
            this.lblAddNotification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbName.Location = new System.Drawing.Point(101, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(65, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "ITStaff";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(396, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Đăng xuất";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintenance.Location = new System.Drawing.Point(10, 73);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(144, 53);
            this.btnMaintenance.TabIndex = 3;
            this.btnMaintenance.Text = "Bảo trì hệ thống";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(11, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(477, 244);
            this.listBox1.TabIndex = 4;
            // 
            // btnMaintenanceOK
            // 
            this.btnMaintenanceOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintenanceOK.Location = new System.Drawing.Point(47, 199);
            this.btnMaintenanceOK.Name = "btnMaintenanceOK";
            this.btnMaintenanceOK.Size = new System.Drawing.Size(92, 34);
            this.btnMaintenanceOK.TabIndex = 5;
            this.btnMaintenanceOK.Text = "Xác nhận";
            this.btnMaintenanceOK.UseVisualStyleBackColor = true;
            this.btnMaintenanceOK.Click += new System.EventHandler(this.btnMaintenanceOK_Click);
            // 
            // btnMaintenanceCancel
            // 
            this.btnMaintenanceCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintenanceCancel.Location = new System.Drawing.Point(172, 199);
            this.btnMaintenanceCancel.Name = "btnMaintenanceCancel";
            this.btnMaintenanceCancel.Size = new System.Drawing.Size(93, 34);
            this.btnMaintenanceCancel.TabIndex = 6;
            this.btnMaintenanceCancel.Text = "Hủy";
            this.btnMaintenanceCancel.UseVisualStyleBackColor = true;
            this.btnMaintenanceCancel.Click += new System.EventHandler(this.btnMaintenanceCancel_Click);
            // 
            // lbMaintenance
            // 
            this.lbMaintenance.AutoSize = true;
            this.lbMaintenance.BackColor = System.Drawing.Color.White;
            this.lbMaintenance.Location = new System.Drawing.Point(22, 151);
            this.lbMaintenance.Name = "lbMaintenance";
            this.lbMaintenance.Size = new System.Drawing.Size(359, 34);
            this.lbMaintenance.TabIndex = 7;
            this.lbMaintenance.Text = "Khi bật chế độ Maintenance, toàn bộ hệ thống sẽ dừng.\nTiếp tục thực hiện?";
            // 
            // btnAddStaffAccount
            // 
            this.btnAddStaffAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStaffAccount.Location = new System.Drawing.Point(160, 73);
            this.btnAddStaffAccount.Name = "btnAddStaffAccount";
            this.btnAddStaffAccount.Size = new System.Drawing.Size(173, 52);
            this.btnAddStaffAccount.TabIndex = 8;
            this.btnAddStaffAccount.Text = "Tạo tài khoản cho nhân viên";
            this.btnAddStaffAccount.UseVisualStyleBackColor = true;
            this.btnAddStaffAccount.Click += new System.EventHandler(this.btnAddStaffAccount_Click);
            // 
            // btnEditStallList
            // 
            this.btnEditStallList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStallList.Location = new System.Drawing.Point(339, 73);
            this.btnEditStallList.Name = "btnEditStallList";
            this.btnEditStallList.Size = new System.Drawing.Size(149, 53);
            this.btnEditStallList.TabIndex = 9;
            this.btnEditStallList.Text = "Thêm/bớt quầy hàng";
            this.btnEditStallList.UseVisualStyleBackColor = true;
            this.btnEditStallList.Click += new System.EventHandler(this.btnEditStallList_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccount.Location = new System.Drawing.Point(368, 151);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(97, 52);
            this.btnAddAccount.TabIndex = 10;
            this.btnAddAccount.Text = "Tạo tài khoản mới";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.BackColor = System.Drawing.Color.White;
            this.lblAccName.Location = new System.Drawing.Point(22, 151);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(138, 17);
            this.lblAccName.TabIndex = 11;
            this.lblAccName.Text = "Nhập tên đăng nhập";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(164, 151);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(175, 22);
            this.txtStaffName.TabIndex = 12;
            // 
            // lblAccPass
            // 
            this.lblAccPass.AutoSize = true;
            this.lblAccPass.BackColor = System.Drawing.Color.White;
            this.lblAccPass.Location = new System.Drawing.Point(22, 187);
            this.lblAccPass.Name = "lblAccPass";
            this.lblAccPass.Size = new System.Drawing.Size(104, 17);
            this.lblAccPass.TabIndex = 13;
            this.lblAccPass.Text = "Nhập mật khẩu";
            // 
            // txtStaffPass
            // 
            this.txtStaffPass.Location = new System.Drawing.Point(164, 188);
            this.txtStaffPass.Name = "txtStaffPass";
            this.txtStaffPass.Size = new System.Drawing.Size(175, 22);
            this.txtStaffPass.TabIndex = 14;
            this.txtStaffPass.UseSystemPasswordChar = true;
            // 
            // lblAccPassCheck
            // 
            this.lblAccPassCheck.AutoSize = true;
            this.lblAccPassCheck.BackColor = System.Drawing.Color.White;
            this.lblAccPassCheck.Location = new System.Drawing.Point(22, 309);
            this.lblAccPassCheck.Name = "lblAccPassCheck";
            this.lblAccPassCheck.Size = new System.Drawing.Size(130, 17);
            this.lblAccPassCheck.TabIndex = 15;
            this.lblAccPassCheck.Text = "Xác nhận mật khẩu";
            // 
            // txtStaffPassCheck
            // 
            this.txtStaffPassCheck.Location = new System.Drawing.Point(164, 306);
            this.txtStaffPassCheck.Name = "txtStaffPassCheck";
            this.txtStaffPassCheck.Size = new System.Drawing.Size(175, 22);
            this.txtStaffPassCheck.TabIndex = 16;
            this.txtStaffPassCheck.UseSystemPasswordChar = true;
            // 
            // lblAddAccNoti
            // 
            this.lblAddAccNoti.AutoSize = true;
            this.lblAddAccNoti.BackColor = System.Drawing.Color.White;
            this.lblAddAccNoti.Location = new System.Drawing.Point(161, 331);
            this.lblAddAccNoti.Name = "lblAddAccNoti";
            this.lblAddAccNoti.Size = new System.Drawing.Size(46, 17);
            this.lblAddAccNoti.TabIndex = 17;
            this.lblAddAccNoti.Text = "label5";
            // 
            // btnAccCancel
            // 
            this.btnAccCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccCancel.Location = new System.Drawing.Point(368, 225);
            this.btnAccCancel.Name = "btnAccCancel";
            this.btnAccCancel.Size = new System.Drawing.Size(97, 30);
            this.btnAccCancel.TabIndex = 18;
            this.btnAccCancel.Text = "Hủy";
            this.btnAccCancel.UseVisualStyleBackColor = true;
            this.btnAccCancel.Click += new System.EventHandler(this.btnAccCancel_Click);
            // 
            // cbAuthorization
            // 
            this.cbAuthorization.FormattingEnabled = true;
            this.cbAuthorization.Items.AddRange(new object[] {
            "MANAGER",
            "ITSTAFF",
            "COOK",
            "STALLOWNER"});
            this.cbAuthorization.Location = new System.Drawing.Point(164, 225);
            this.cbAuthorization.Name = "cbAuthorization";
            this.cbAuthorization.Size = new System.Drawing.Size(175, 24);
            this.cbAuthorization.TabIndex = 19;
            // 
            // lblAuthorization
            // 
            this.lblAuthorization.AutoSize = true;
            this.lblAuthorization.BackColor = System.Drawing.Color.White;
            this.lblAuthorization.Location = new System.Drawing.Point(22, 225);
            this.lblAuthorization.Name = "lblAuthorization";
            this.lblAuthorization.Size = new System.Drawing.Size(130, 17);
            this.lblAuthorization.TabIndex = 20;
            this.lblAuthorization.Text = "Nhập loại tài khoản";
            // 
            // lblAccID
            // 
            this.lblAccID.AutoSize = true;
            this.lblAccID.BackColor = System.Drawing.Color.White;
            this.lblAccID.Location = new System.Drawing.Point(22, 269);
            this.lblAccID.Name = "lblAccID";
            this.lblAccID.Size = new System.Drawing.Size(59, 17);
            this.lblAccID.TabIndex = 21;
            this.lblAccID.Text = "Nhập ID";
            // 
            // txtAccID
            // 
            this.txtAccID.Location = new System.Drawing.Point(164, 266);
            this.txtAccID.Name = "txtAccID";
            this.txtAccID.Size = new System.Drawing.Size(175, 22);
            this.txtAccID.TabIndex = 22;
            // 
            // lblMaintenanceFailed
            // 
            this.lblMaintenanceFailed.AutoSize = true;
            this.lblMaintenanceFailed.BackColor = System.Drawing.Color.White;
            this.lblMaintenanceFailed.Location = new System.Drawing.Point(80, 242);
            this.lblMaintenanceFailed.Name = "lblMaintenanceFailed";
            this.lblMaintenanceFailed.Size = new System.Drawing.Size(46, 17);
            this.lblMaintenanceFailed.TabIndex = 23;
            this.lblMaintenanceFailed.Text = "label5";
            // 
            // btnAddStall
            // 
            this.btnAddStall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStall.Location = new System.Drawing.Point(25, 151);
            this.btnAddStall.Name = "btnAddStall";
            this.btnAddStall.Size = new System.Drawing.Size(133, 34);
            this.btnAddStall.TabIndex = 24;
            this.btnAddStall.Text = "Thêm quầy hàng";
            this.btnAddStall.UseVisualStyleBackColor = true;
            this.btnAddStall.Click += new System.EventHandler(this.btnAddStall_Click);
            // 
            // btnRemoveStall
            // 
            this.btnRemoveStall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveStall.Location = new System.Drawing.Point(164, 151);
            this.btnRemoveStall.Name = "btnRemoveStall";
            this.btnRemoveStall.Size = new System.Drawing.Size(128, 34);
            this.btnRemoveStall.TabIndex = 25;
            this.btnRemoveStall.Text = "Xóa quầy hàng";
            this.btnRemoveStall.UseVisualStyleBackColor = true;
            this.btnRemoveStall.Click += new System.EventHandler(this.btnRemoveStall_Click);
            // 
            // lsEditStall
            // 
            this.lsEditStall.FormattingEnabled = true;
            this.lsEditStall.ItemHeight = 16;
            this.lsEditStall.Location = new System.Drawing.Point(25, 193);
            this.lsEditStall.Name = "lsEditStall";
            this.lsEditStall.Size = new System.Drawing.Size(451, 148);
            this.lsEditStall.TabIndex = 26;
            // 
            // lblStallID
            // 
            this.lblStallID.AutoSize = true;
            this.lblStallID.BackColor = System.Drawing.Color.White;
            this.lblStallID.Location = new System.Drawing.Point(47, 220);
            this.lblStallID.Name = "lblStallID";
            this.lblStallID.Size = new System.Drawing.Size(59, 17);
            this.lblStallID.TabIndex = 27;
            this.lblStallID.Text = "Nhập ID";
            // 
            // lblStallName
            // 
            this.lblStallName.AutoSize = true;
            this.lblStallName.BackColor = System.Drawing.Color.White;
            this.lblStallName.Location = new System.Drawing.Point(47, 252);
            this.lblStallName.Name = "lblStallName";
            this.lblStallName.Size = new System.Drawing.Size(137, 17);
            this.lblStallName.TabIndex = 28;
            this.lblStallName.Text = "Nhập tên quầy hàng";
            // 
            // txtStallID
            // 
            this.txtStallID.Location = new System.Drawing.Point(211, 217);
            this.txtStallID.Name = "txtStallID";
            this.txtStallID.Size = new System.Drawing.Size(223, 22);
            this.txtStallID.TabIndex = 29;
            // 
            // txtStallName
            // 
            this.txtStallName.Location = new System.Drawing.Point(211, 249);
            this.txtStallName.Name = "txtStallName";
            this.txtStallName.Size = new System.Drawing.Size(223, 22);
            this.txtStallName.TabIndex = 30;
            // 
            // btnAddStallCmd
            // 
            this.btnAddStallCmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStallCmd.Location = new System.Drawing.Point(243, 277);
            this.btnAddStallCmd.Name = "btnAddStallCmd";
            this.btnAddStallCmd.Size = new System.Drawing.Size(74, 34);
            this.btnAddStallCmd.TabIndex = 31;
            this.btnAddStallCmd.Text = "Thêm";
            this.btnAddStallCmd.UseVisualStyleBackColor = true;
            this.btnAddStallCmd.Click += new System.EventHandler(this.btnAddStallCmd_Click);
            // 
            // btnAddStallCancel
            // 
            this.btnAddStallCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStallCancel.Location = new System.Drawing.Point(339, 277);
            this.btnAddStallCancel.Name = "btnAddStallCancel";
            this.btnAddStallCancel.Size = new System.Drawing.Size(74, 34);
            this.btnAddStallCancel.TabIndex = 32;
            this.btnAddStallCancel.Text = "Hủy";
            this.btnAddStallCancel.UseVisualStyleBackColor = true;
            this.btnAddStallCancel.Click += new System.EventHandler(this.btnAddStallCancel_Click);
            // 
            // btnRemoveStallCmd
            // 
            this.btnRemoveStallCmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveStallCmd.Location = new System.Drawing.Point(291, 249);
            this.btnRemoveStallCmd.Name = "btnRemoveStallCmd";
            this.btnRemoveStallCmd.Size = new System.Drawing.Size(74, 34);
            this.btnRemoveStallCmd.TabIndex = 35;
            this.btnRemoveStallCmd.Text = "Xóa";
            this.btnRemoveStallCmd.UseVisualStyleBackColor = true;
            this.btnRemoveStallCmd.Click += new System.EventHandler(this.btnRemoveStallCmd_Click);
            // 
            // btnRemoveStallCancel
            // 
            this.btnRemoveStallCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveStallCancel.Location = new System.Drawing.Point(371, 249);
            this.btnRemoveStallCancel.Name = "btnRemoveStallCancel";
            this.btnRemoveStallCancel.Size = new System.Drawing.Size(74, 34);
            this.btnRemoveStallCancel.TabIndex = 36;
            this.btnRemoveStallCancel.Text = "Hủy";
            this.btnRemoveStallCancel.UseVisualStyleBackColor = true;
            this.btnRemoveStallCancel.Click += new System.EventHandler(this.btnRemoveStallCancel_Click);
            // 
            // lblRemoveNotification
            // 
            this.lblRemoveNotification.AutoSize = true;
            this.lblRemoveNotification.BackColor = System.Drawing.Color.White;
            this.lblRemoveNotification.Location = new System.Drawing.Point(208, 286);
            this.lblRemoveNotification.Name = "lblRemoveNotification";
            this.lblRemoveNotification.Size = new System.Drawing.Size(46, 17);
            this.lblRemoveNotification.TabIndex = 37;
            this.lblRemoveNotification.Text = "label5";
            // 
            // btnRemoveCheck
            // 
            this.btnRemoveCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCheck.Location = new System.Drawing.Point(211, 249);
            this.btnRemoveCheck.Name = "btnRemoveCheck";
            this.btnRemoveCheck.Size = new System.Drawing.Size(74, 34);
            this.btnRemoveCheck.TabIndex = 38;
            this.btnRemoveCheck.Text = "Kiểm tra";
            this.btnRemoveCheck.UseVisualStyleBackColor = true;
            this.btnRemoveCheck.Click += new System.EventHandler(this.btnRemoveCheck_Click);
            // 
            // lblAddNotification
            // 
            this.lblAddNotification.AutoSize = true;
            this.lblAddNotification.BackColor = System.Drawing.Color.White;
            this.lblAddNotification.Location = new System.Drawing.Point(208, 314);
            this.lblAddNotification.Name = "lblAddNotification";
            this.lblAddNotification.Size = new System.Drawing.Size(46, 17);
            this.lblAddNotification.TabIndex = 39;
            this.lblAddNotification.Text = "label5";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(504, 390);
            this.Controls.Add(this.lblAddNotification);
            this.Controls.Add(this.btnRemoveCheck);
            this.Controls.Add(this.lblRemoveNotification);
            this.Controls.Add(this.btnRemoveStallCancel);
            this.Controls.Add(this.btnRemoveStallCmd);
            this.Controls.Add(this.btnAddStallCancel);
            this.Controls.Add(this.btnAddStallCmd);
            this.Controls.Add(this.txtStallName);
            this.Controls.Add(this.txtStallID);
            this.Controls.Add(this.lblStallName);
            this.Controls.Add(this.lblStallID);
            this.Controls.Add(this.btnRemoveStall);
            this.Controls.Add(this.btnAddStall);
            this.Controls.Add(this.lblMaintenanceFailed);
            this.Controls.Add(this.txtAccID);
            this.Controls.Add(this.lblAccID);
            this.Controls.Add(this.lblAuthorization);
            this.Controls.Add(this.cbAuthorization);
            this.Controls.Add(this.btnAccCancel);
            this.Controls.Add(this.lblAddAccNoti);
            this.Controls.Add(this.txtStaffPassCheck);
            this.Controls.Add(this.lblAccPassCheck);
            this.Controls.Add(this.txtStaffPass);
            this.Controls.Add(this.lblAccPass);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.lblAccName);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.btnEditStallList);
            this.Controls.Add(this.btnAddStaffAccount);
            this.Controls.Add(this.lbMaintenance);
            this.Controls.Add(this.btnMaintenanceCancel);
            this.Controls.Add(this.btnMaintenanceOK);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsEditStall);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "ITStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMaintenanceOK;
        private System.Windows.Forms.Button btnMaintenanceCancel;
        private System.Windows.Forms.Label lbMaintenance;
        private System.Windows.Forms.Button btnAddStaffAccount;
        private System.Windows.Forms.Button btnEditStallList;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblAccPass;
        private System.Windows.Forms.TextBox txtStaffPass;
        private System.Windows.Forms.Label lblAccPassCheck;
        private System.Windows.Forms.TextBox txtStaffPassCheck;
        private System.Windows.Forms.Label lblAddAccNoti;
        private System.Windows.Forms.Button btnAccCancel;
        private System.Windows.Forms.ComboBox cbAuthorization;
        private System.Windows.Forms.Label lblAuthorization;
        private System.Windows.Forms.Label lblAccID;
        private System.Windows.Forms.TextBox txtAccID;
        private System.Windows.Forms.Label lblMaintenanceFailed;
        private System.Windows.Forms.Button btnAddStall;
        private System.Windows.Forms.Button btnRemoveStall;
        private System.Windows.Forms.ListBox lsEditStall;
        private System.Windows.Forms.Label lblStallID;
        private System.Windows.Forms.Label lblStallName;
        private System.Windows.Forms.TextBox txtStallID;
        private System.Windows.Forms.TextBox txtStallName;
        private System.Windows.Forms.Button btnAddStallCmd;
        private System.Windows.Forms.Button btnAddStallCancel;
        private System.Windows.Forms.Button btnRemoveStallCmd;
        private System.Windows.Forms.Button btnRemoveStallCancel;
        private System.Windows.Forms.Label lblRemoveNotification;
        private System.Windows.Forms.Button btnRemoveCheck;
        private System.Windows.Forms.Label lblAddNotification;
    }
}