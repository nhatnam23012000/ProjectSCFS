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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            string[] arr = new string[5];
            arr[0] = "01/01/2020";
            arr[1] = "Circle K";
            arr[2] = "5000$";
            arr[3] = "12000$";
            arr[4] = "7000$";
            ListViewItem l1 = new ListViewItem(arr);
            vbReportInfo.Items.Add(l1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
