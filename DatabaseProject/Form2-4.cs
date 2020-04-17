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
    public partial class Form2_4 : Form
    {
        public Form2_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Form2_2 form2_2 = new Form2_2();
            form2_2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Form3_2 form3_2 = new Form3_2();
            form3_2.Visible = true;
        }
    }
}
