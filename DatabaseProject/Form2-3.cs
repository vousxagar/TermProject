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
    public partial class Form2_3 : Form
    {
        public Form2_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Form2 form2 = new Form2();
            form2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Form3 form3 = new Form3();
            form3.Visible = true;
        }
    }
}
