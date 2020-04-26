using MySql.Data.MySqlClient;
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
            this.Hide();
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            pic_add form6 = new pic_add(StaffName, StaffID);
            form6.Visible = true;
        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("คุณต้องการออกจากระบบหรือไม่", " C A F É B A R", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            this.Visible = false;
            Form2_2 form2_2 = new Form2_2();
            form2_2.Visible = true;
        }
        string StaffCode = string.Empty;

        private void Form4_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database=final; allowuservariables=True");
            MySqlCommand command = new MySqlCommand("select StaffName, StaffCode from staffs where StaffID = '" + StaffID + "'", connection);
            connection.Open();

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    StaffName = reader.GetString(0);
                    StaffCode = reader.GetString(1);
                }
            }
            reader.Close();
            lbl_time.Text = DateTime.Now.ToString();
            lbl_fullname.Text = StaffName;
            lbl_code.Text = StaffCode;
            lbl_username.Text = StaffID;
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 form9 = new Form9();
            form9.ShowDialog();
        }
    }

}
