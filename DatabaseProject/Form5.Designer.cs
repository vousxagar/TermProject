﻿namespace DatabaseProject
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
            this.BillGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.ProductIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buy_button = new System.Windows.Forms.Button();
            this.TotalBillBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BillGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.ProductsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BillGroupBox
            // 
            this.BillGroupBox.Controls.Add(this.button1);
            this.BillGroupBox.Controls.Add(this.ProductsGridView);
            this.BillGroupBox.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillGroupBox.Location = new System.Drawing.Point(13, 14);
            this.BillGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.BillGroupBox.Name = "BillGroupBox";
            this.BillGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.BillGroupBox.Size = new System.Drawing.Size(651, 592);
            this.BillGroupBox.TabIndex = 11;
            this.BillGroupBox.TabStop = false;
            this.BillGroupBox.Text = "DETAIL";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(539, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AllowUserToAddRows = false;
            this.ProductsGridView.AllowUserToDeleteRows = false;
            this.ProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDColumn,
            this.ProductNameColumn,
            this.ProductPriceColumn,
            this.ProductQuantityColumn,
            this.TotalPriceColumn,
            this.DeleteColumn});
            this.ProductsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsGridView.Location = new System.Drawing.Point(4, 29);
            this.ProductsGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.ReadOnly = true;
            this.ProductsGridView.RowHeadersVisible = false;
            this.ProductsGridView.RowHeadersWidth = 51;
            this.ProductsGridView.Size = new System.Drawing.Size(643, 559);
            this.ProductsGridView.TabIndex = 0;
            this.ProductsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellClick);
            this.ProductsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellContentClick);
            // 
            // ProductIDColumn
            // 
            this.ProductIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductIDColumn.FillWeight = 50F;
            this.ProductIDColumn.HeaderText = "ID";
            this.ProductIDColumn.MinimumWidth = 6;
            this.ProductIDColumn.Name = "ProductIDColumn";
            this.ProductIDColumn.ReadOnly = true;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductNameColumn.HeaderText = "Name";
            this.ProductNameColumn.MinimumWidth = 6;
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.ReadOnly = true;
            // 
            // ProductPriceColumn
            // 
            this.ProductPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductPriceColumn.HeaderText = "Price";
            this.ProductPriceColumn.MinimumWidth = 6;
            this.ProductPriceColumn.Name = "ProductPriceColumn";
            this.ProductPriceColumn.ReadOnly = true;
            // 
            // ProductQuantityColumn
            // 
            this.ProductQuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductQuantityColumn.HeaderText = "Quantity";
            this.ProductQuantityColumn.MinimumWidth = 6;
            this.ProductQuantityColumn.Name = "ProductQuantityColumn";
            this.ProductQuantityColumn.ReadOnly = true;
            // 
            // TotalPriceColumn
            // 
            this.TotalPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPriceColumn.HeaderText = "Total";
            this.TotalPriceColumn.MinimumWidth = 6;
            this.TotalPriceColumn.Name = "TotalPriceColumn";
            this.TotalPriceColumn.ReadOnly = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.MinimumWidth = 6;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            // 
            // ProductsGroupBox
            // 
            this.ProductsGroupBox.Controls.Add(this.ProductsFlowPanel);
            this.ProductsGroupBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsGroupBox.Location = new System.Drawing.Point(691, 14);
            this.ProductsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProductsGroupBox.Name = "ProductsGroupBox";
            this.ProductsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ProductsGroupBox.Size = new System.Drawing.Size(517, 535);
            this.ProductsGroupBox.TabIndex = 12;
            this.ProductsGroupBox.TabStop = false;
            this.ProductsGroupBox.Text = "MENU COFFE";
            // 
            // ProductsFlowPanel
            // 
            this.ProductsFlowPanel.AutoScroll = true;
            this.ProductsFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsFlowPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProductsFlowPanel.Location = new System.Drawing.Point(4, 29);
            this.ProductsFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ProductsFlowPanel.Name = "ProductsFlowPanel";
            this.ProductsFlowPanel.Size = new System.Drawing.Size(509, 502);
            this.ProductsFlowPanel.TabIndex = 0;
            this.ProductsFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ProductsFlowPanel_Paint);
            // 
            // buy_button
            // 
            this.buy_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buy_button.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy_button.Location = new System.Drawing.Point(791, 619);
            this.buy_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buy_button.Name = "buy_button";
            this.buy_button.Size = new System.Drawing.Size(269, 48);
            this.buy_button.TabIndex = 13;
            this.buy_button.Text = "BUY";
            this.buy_button.UseVisualStyleBackColor = false;
            this.buy_button.Click += new System.EventHandler(this.buy_button_Click);
            // 
            // TotalBillBox
            // 
            this.TotalBillBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBillBox.Location = new System.Drawing.Point(834, 570);
            this.TotalBillBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalBillBox.Multiline = true;
            this.TotalBillBox.Name = "TotalBillBox";
            this.TotalBillBox.Size = new System.Drawing.Size(279, 36);
            this.TotalBillBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(732, 575);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "TOTAL";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::DatabaseProject.Properties.Resources.bar_1869656_19201;
            this.ClientSize = new System.Drawing.Size(1237, 679);
            this.Controls.Add(this.TotalBillBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buy_button);
            this.Controls.Add(this.ProductsGroupBox);
            this.Controls.Add(this.BillGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form5";
            this.Text = "customers";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.BillGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.ProductsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BillGroupBox;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPriceColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.GroupBox ProductsGroupBox;
        private System.Windows.Forms.FlowLayoutPanel ProductsFlowPanel;
        private System.Windows.Forms.Button buy_button;
        private System.Windows.Forms.TextBox TotalBillBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}