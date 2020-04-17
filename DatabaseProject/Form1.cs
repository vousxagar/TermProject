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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2_3 form2_3 = new Form2_3();
            form2_3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Visible = false;
            Form2_4 form2_4 = new Form2_4();
            //form2_4.Visible = true;
            form2_4.ShowDialog();
        }
    }
}
