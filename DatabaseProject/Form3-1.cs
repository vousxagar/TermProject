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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2_3 form2_3 = new Form2_3();
            form2_3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("แล้วพบกันใหม่โอกาศหน้าที่ร้าน C A F É B A R ", "C A F É B A R", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
