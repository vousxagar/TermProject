namespace DatabaseProject
{
    partial class Form5
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
            this.Button1 = new System.Windows.Forms.Button();
            this.txt_coffee_amount = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Txt_coffee_id = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.listview_sale = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Btn_purchase = new System.Windows.Forms.Button();
            this.Btn_delete_all = new System.Windows.Forms.Button();
            this.Btn_select_delete = new System.Windows.Forms.Button();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Lbl_date_sale = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Lbl_sale_id = new System.Windows.Forms.Label();
            this.รหัสการขาย = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel3.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(404, 15);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(123, 44);
            this.Button1.TabIndex = 16;
            this.Button1.Text = "เพิ่ม";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // txt_coffee_amount
            // 
            this.txt_coffee_amount.Location = new System.Drawing.Point(269, 29);
            this.txt_coffee_amount.Multiline = true;
            this.txt_coffee_amount.Name = "txt_coffee_amount";
            this.txt_coffee_amount.Size = new System.Drawing.Size(94, 22);
            this.txt_coffee_amount.TabIndex = 15;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(205, 29);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(46, 17);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "จำนวน";
            // 
            // Txt_coffee_id
            // 
            this.Txt_coffee_id.Location = new System.Drawing.Point(72, 121);
            this.Txt_coffee_id.Multiline = true;
            this.Txt_coffee_id.Name = "Txt_coffee_id";
            this.Txt_coffee_id.Size = new System.Drawing.Size(113, 22);
            this.Txt_coffee_id.TabIndex = 13;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 124);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(61, 17);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "รหัสสินค้า";
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.Panel7);
            this.Panel3.Controls.Add(this.Panel6);
            this.Panel3.Controls.Add(this.Panel5);
            this.Panel3.Controls.Add(this.Panel4);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(549, 645);
            this.Panel3.TabIndex = 11;
            // 
            // Panel7
            // 
            this.Panel7.Controls.Add(this.listview_sale);
            this.Panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel7.Location = new System.Drawing.Point(0, 210);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(549, 375);
            this.Panel7.TabIndex = 7;
            // 
            // listview_sale
            // 
            this.listview_sale.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.ColumnHeader7});
            this.listview_sale.FullRowSelect = true;
            this.listview_sale.GridLines = true;
            this.listview_sale.HideSelection = false;
            this.listview_sale.Location = new System.Drawing.Point(26, 3);
            this.listview_sale.Name = "listview_sale";
            this.listview_sale.Size = new System.Drawing.Size(488, 366);
            this.listview_sale.TabIndex = 1;
            this.listview_sale.UseCompatibleStateImageBehavior = false;
            this.listview_sale.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "ลำดับ";
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "รหัสสินค้า";
            this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader2.Width = 86;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "รายการ";
            this.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader3.Width = 157;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "หน่วย";
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "จำนวน";
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "ราคารวม";
            this.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Panel6
            // 
            this.Panel6.Controls.Add(this.Btn_purchase);
            this.Panel6.Controls.Add(this.Btn_delete_all);
            this.Panel6.Controls.Add(this.Btn_select_delete);
            this.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel6.Location = new System.Drawing.Point(0, 585);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(549, 60);
            this.Panel6.TabIndex = 6;
            // 
            // Btn_purchase
            // 
            this.Btn_purchase.Location = new System.Drawing.Point(453, 9);
            this.Btn_purchase.Name = "Btn_purchase";
            this.Btn_purchase.Size = new System.Drawing.Size(74, 38);
            this.Btn_purchase.TabIndex = 4;
            this.Btn_purchase.Text = "คิดเงิน";
            this.Btn_purchase.UseVisualStyleBackColor = true;
            // 
            // Btn_delete_all
            // 
            this.Btn_delete_all.Location = new System.Drawing.Point(158, 9);
            this.Btn_delete_all.Name = "Btn_delete_all";
            this.Btn_delete_all.Size = new System.Drawing.Size(75, 38);
            this.Btn_delete_all.TabIndex = 3;
            this.Btn_delete_all.Text = "ลบทั้งหมด";
            this.Btn_delete_all.UseVisualStyleBackColor = true;
            // 
            // Btn_select_delete
            // 
            this.Btn_select_delete.Location = new System.Drawing.Point(51, 9);
            this.Btn_select_delete.Name = "Btn_select_delete";
            this.Btn_select_delete.Size = new System.Drawing.Size(75, 38);
            this.Btn_select_delete.TabIndex = 2;
            this.Btn_select_delete.Text = "ลบที่เลือก";
            this.Btn_select_delete.UseVisualStyleBackColor = true;
            // 
            // Panel5
            // 
            this.Panel5.Controls.Add(this.Button1);
            this.Panel5.Controls.Add(this.Lbl_date_sale);
            this.Panel5.Controls.Add(this.Label3);
            this.Panel5.Controls.Add(this.txt_coffee_amount);
            this.Panel5.Controls.Add(this.Label4);
            this.Panel5.Controls.Add(this.Lbl_sale_id);
            this.Panel5.Controls.Add(this.รหัสการขาย);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel5.Location = new System.Drawing.Point(0, 95);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(549, 115);
            this.Panel5.TabIndex = 5;
            // 
            // Lbl_date_sale
            // 
            this.Lbl_date_sale.AutoSize = true;
            this.Lbl_date_sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_date_sale.Location = new System.Drawing.Point(460, 74);
            this.Lbl_date_sale.Name = "Lbl_date_sale";
            this.Lbl_date_sale.Size = new System.Drawing.Size(32, 17);
            this.Lbl_date_sale.TabIndex = 12;
            this.Lbl_date_sale.Text = "......";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(344, 74);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(101, 17);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "วัน/เดือน/ปี ขาย :";
            // 
            // Lbl_sale_id
            // 
            this.Lbl_sale_id.AutoSize = true;
            this.Lbl_sale_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sale_id.Location = new System.Drawing.Point(136, 74);
            this.Lbl_sale_id.Name = "Lbl_sale_id";
            this.Lbl_sale_id.Size = new System.Drawing.Size(32, 17);
            this.Lbl_sale_id.TabIndex = 10;
            this.Lbl_sale_id.Text = "......";
            // 
            // รหัสการขาย
            // 
            this.รหัสการขาย.AutoSize = true;
            this.รหัสการขาย.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.รหัสการขาย.Location = new System.Drawing.Point(36, 74);
            this.รหัสการขาย.Name = "รหัสการขาย";
            this.รหัสการขาย.Size = new System.Drawing.Size(85, 17);
            this.รหัสการขาย.TabIndex = 9;
            this.รหัสการขาย.Text = "รหัสการขาย : ";
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.txt_total);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel4.Location = new System.Drawing.Point(0, 0);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(549, 95);
            this.Panel4.TabIndex = 0;
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_total.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_total.Font = new System.Drawing.Font("Angsana New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_total.Location = new System.Drawing.Point(0, 0);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(549, 118);
            this.txt_total.TabIndex = 0;
            this.txt_total.Text = "0.00";
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Panel1
            // 
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel1.Location = new System.Drawing.Point(549, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(25, 645);
            this.Panel1.TabIndex = 10;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 645);
            this.Controls.Add(this.Txt_coffee_id);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form5";
            this.Text = "S T A F F S S A L E ";
            this.Panel3.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txt_coffee_amount;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox Txt_coffee_id;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Panel Panel7;
        internal System.Windows.Forms.ListView listview_sale;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
        internal System.Windows.Forms.ColumnHeader ColumnHeader7;
        internal System.Windows.Forms.Panel Panel6;
        internal System.Windows.Forms.Button Btn_purchase;
        internal System.Windows.Forms.Button Btn_delete_all;
        internal System.Windows.Forms.Button Btn_select_delete;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Label Lbl_date_sale;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Lbl_sale_id;
        internal System.Windows.Forms.Label รหัสการขาย;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.TextBox txt_total;
        internal System.Windows.Forms.Panel Panel1;
    }
}