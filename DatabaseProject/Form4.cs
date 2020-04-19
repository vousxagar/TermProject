using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private string staffname;
        private string StaffName
        {
            get { return staffname; }
            set { staffname = value; }
        }
        private string staffID;
        private string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }
        public Form4(string StaffName, string StaffID)
        {
            InitializeComponent();
            this.StaffName = StaffName;
            this.StaffID = StaffID;
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 form6 = new Form6(StaffName,StaffID);
            form6.Visible = true;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 form5 = new Form5();
            form5.Visible = true;
        }
    }

}
