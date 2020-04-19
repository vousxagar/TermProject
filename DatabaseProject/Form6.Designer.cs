namespace DatabaseProject
{
    partial class Form6
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
            this.label4 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addnew = new System.Windows.Forms.Button();
            this.btn_select_addpic = new System.Windows.Forms.Button();
            this.pic_add = new System.Windows.Forms.PictureBox();
            this.txt_add_name = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txt_add_id = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save_edit = new System.Windows.Forms.Button();
            this.btn_select_edit = new System.Windows.Forms.Button();
            this.pic_edit = new System.Windows.Forms.PictureBox();
            this.txt_edit_name = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txt_edit_id = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Detail = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_add)).BeginInit();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 20;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl1.Location = new System.Drawing.Point(510, 28);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(413, 464);
            this.TabControl1.TabIndex = 19;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.textBox2);
            this.TabPage1.Controls.Add(this.label1);
            this.TabPage1.Controls.Add(this.btn_addnew);
            this.TabPage1.Controls.Add(this.btn_select_addpic);
            this.TabPage1.Controls.Add(this.pic_add);
            this.TabPage1.Controls.Add(this.txt_add_name);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.txt_add_id);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage1.Location = new System.Drawing.Point(4, 29);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(405, 431);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "เพิ่มกาแฟ";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(118, 83);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 23);
            this.textBox2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "ราคา";
            // 
            // btn_addnew
            // 
            this.btn_addnew.Font = new System.Drawing.Font("Angsana New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addnew.ForeColor = System.Drawing.Color.Black;
            this.btn_addnew.Location = new System.Drawing.Point(88, 374);
            this.btn_addnew.Name = "btn_addnew";
            this.btn_addnew.Size = new System.Drawing.Size(128, 38);
            this.btn_addnew.TabIndex = 15;
            this.btn_addnew.Text = "บันทึก";
            this.btn_addnew.UseVisualStyleBackColor = true;
            this.btn_addnew.Click += new System.EventHandler(this.btn_addnew_Click);
            // 
            // btn_select_addpic
            // 
            this.btn_select_addpic.Font = new System.Drawing.Font("Angsana New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select_addpic.ForeColor = System.Drawing.Color.Black;
            this.btn_select_addpic.Location = new System.Drawing.Point(272, 250);
            this.btn_select_addpic.Name = "btn_select_addpic";
            this.btn_select_addpic.Size = new System.Drawing.Size(110, 38);
            this.btn_select_addpic.TabIndex = 14;
            this.btn_select_addpic.Text = "เลือกรูปภาพ";
            this.btn_select_addpic.UseVisualStyleBackColor = true;
            this.btn_select_addpic.Click += new System.EventHandler(this.btn_select_addpic_Click);
            // 
            // pic_add
            // 
            this.pic_add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_add.Location = new System.Drawing.Point(41, 190);
            this.pic_add.Name = "pic_add";
            this.pic_add.Size = new System.Drawing.Size(216, 168);
            this.pic_add.TabIndex = 13;
            this.pic_add.TabStop = false;
            // 
            // txt_add_name
            // 
            this.txt_add_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add_name.Location = new System.Drawing.Point(118, 54);
            this.txt_add_name.Multiline = true;
            this.txt_add_name.Name = "txt_add_name";
            this.txt_add_name.Size = new System.Drawing.Size(156, 23);
            this.txt_add_name.TabIndex = 2;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(24, 57);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(67, 20);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "ชื่อกาแฟ";
            // 
            // txt_add_id
            // 
            this.txt_add_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add_id.Location = new System.Drawing.Point(118, 25);
            this.txt_add_id.Multiline = true;
            this.txt_add_id.Name = "txt_add_id";
            this.txt_add_id.Size = new System.Drawing.Size(156, 23);
            this.txt_add_id.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(24, 28);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(36, 20);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "รหัส";
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.textBox1);
            this.TabPage2.Controls.Add(this.label3);
            this.TabPage2.Controls.Add(this.btn_save_edit);
            this.TabPage2.Controls.Add(this.btn_select_edit);
            this.TabPage2.Controls.Add(this.pic_edit);
            this.TabPage2.Controls.Add(this.txt_edit_name);
            this.TabPage2.Controls.Add(this.Label10);
            this.TabPage2.Controls.Add(this.txt_edit_id);
            this.TabPage2.Controls.Add(this.Label11);
            this.TabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage2.Location = new System.Drawing.Point(4, 29);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(405, 431);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "แก้ไขกาแฟ";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(113, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 23);
            this.textBox1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "ราคา";
            // 
            // btn_save_edit
            // 
            this.btn_save_edit.Font = new System.Drawing.Font("Angsana New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_save_edit.Location = new System.Drawing.Point(97, 377);
            this.btn_save_edit.Name = "btn_save_edit";
            this.btn_save_edit.Size = new System.Drawing.Size(138, 38);
            this.btn_save_edit.TabIndex = 23;
            this.btn_save_edit.Text = "แก้ไข";
            this.btn_save_edit.UseVisualStyleBackColor = true;
            this.btn_save_edit.Click += new System.EventHandler(this.btn_save_edit_Click);
            // 
            // btn_select_edit
            // 
            this.btn_select_edit.Font = new System.Drawing.Font("Angsana New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_select_edit.Location = new System.Drawing.Point(276, 248);
            this.btn_select_edit.Name = "btn_select_edit";
            this.btn_select_edit.Size = new System.Drawing.Size(110, 38);
            this.btn_select_edit.TabIndex = 22;
            this.btn_select_edit.Text = "เลือกรูปภาพ";
            this.btn_select_edit.UseVisualStyleBackColor = true;
            this.btn_select_edit.Click += new System.EventHandler(this.btn_select_edit_Click);
            // 
            // pic_edit
            // 
            this.pic_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_edit.Location = new System.Drawing.Point(44, 194);
            this.pic_edit.Name = "pic_edit";
            this.pic_edit.Size = new System.Drawing.Size(216, 168);
            this.pic_edit.TabIndex = 21;
            this.pic_edit.TabStop = false;
            // 
            // txt_edit_name
            // 
            this.txt_edit_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edit_name.Location = new System.Drawing.Point(113, 46);
            this.txt_edit_name.Multiline = true;
            this.txt_edit_name.Name = "txt_edit_name";
            this.txt_edit_name.Size = new System.Drawing.Size(156, 23);
            this.txt_edit_name.TabIndex = 18;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.ForeColor = System.Drawing.Color.Black;
            this.Label10.Location = new System.Drawing.Point(19, 49);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(67, 20);
            this.Label10.TabIndex = 19;
            this.Label10.Text = "ชื่อกาแฟ";
            // 
            // txt_edit_id
            // 
            this.txt_edit_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edit_id.Location = new System.Drawing.Point(113, 17);
            this.txt_edit_id.Multiline = true;
            this.txt_edit_id.Name = "txt_edit_id";
            this.txt_edit_id.Size = new System.Drawing.Size(156, 23);
            this.txt_edit_id.TabIndex = 17;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.ForeColor = System.Drawing.Color.Black;
            this.Label11.Location = new System.Drawing.Point(19, 20);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(36, 20);
            this.Label11.TabIndex = 16;
            this.Label11.Text = "รหัส";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detail,
            this.id,
            this.name,
            this.pricee,
            this.Delete});
            this.dataGridView2.Location = new System.Drawing.Point(23, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(457, 464);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detail";
            this.Detail.MinimumWidth = 6;
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Width = 150;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 130;
            // 
            // pricee
            // 
            this.pricee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pricee.HeaderText = "Price";
            this.pricee.MinimumWidth = 6;
            this.pricee.Name = "pricee";
            this.pricee.ReadOnly = true;
            this.pricee.Width = 69;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 55;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 525);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form6";
            this.Text = "M A N A G E";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_add)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btn_addnew;
        internal System.Windows.Forms.Button btn_select_addpic;
        internal System.Windows.Forms.PictureBox pic_add;
        internal System.Windows.Forms.TextBox txt_add_name;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txt_add_id;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button btn_save_edit;
        internal System.Windows.Forms.Button btn_select_edit;
        internal System.Windows.Forms.PictureBox pic_edit;
        internal System.Windows.Forms.TextBox txt_edit_name;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txt_edit_id;
        internal System.Windows.Forms.Label Label11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewImageColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricee;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}