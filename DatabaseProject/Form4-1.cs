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
    public partial class Form4_1 : Form
    {


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

        


        public Form4_1(string StaffName , string StaffID)
        {
            InitializeComponent();
            this.StaffName = StaffName;
            this.StaffID = StaffID;
        }

        public Form4_1()
        {
            InitializeComponent();
        }

    }
}
