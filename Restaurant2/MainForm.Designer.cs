namespace Restaurant2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
       
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_count = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_category = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_logadmin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnComplete);
            this.groupBox1.Controls.Add(this.btn_order);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtbx_count);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbx_price);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbx_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbx_category);
            this.groupBox1.Location = new System.Drawing.Point(34, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(573, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(317, 349);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(4);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(138, 28);
            this.btnComplete.TabIndex = 9;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(118, 349);
            this.btn_order.Margin = new System.Windows.Forms.Padding(4);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(138, 28);
            this.btn_order.TabIndex = 8;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Count";
            // 
            // txtbx_count
            // 
            this.txtbx_count.Location = new System.Drawing.Point(119, 289);
            this.txtbx_count.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_count.Name = "txtbx_count";
            this.txtbx_count.Size = new System.Drawing.Size(336, 22);
            this.txtbx_count.TabIndex = 6;
            this.txtbx_count.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // txtbx_price
            // 
            this.txtbx_price.Location = new System.Drawing.Point(119, 229);
            this.txtbx_price.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_price.Name = "txtbx_price";
            this.txtbx_price.ReadOnly = true;
            this.txtbx_price.Size = new System.Drawing.Size(336, 22);
            this.txtbx_price.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // cmbx_name
            // 
            this.cmbx_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_name.FormattingEnabled = true;
            this.cmbx_name.Location = new System.Drawing.Point(119, 154);
            this.cmbx_name.Margin = new System.Windows.Forms.Padding(4);
            this.cmbx_name.Name = "cmbx_name";
            this.cmbx_name.Size = new System.Drawing.Size(336, 24);
            this.cmbx_name.TabIndex = 2;
            this.cmbx_name.SelectedValueChanged += new System.EventHandler(this.cmbx_name_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // cmbx_category
            // 
            this.cmbx_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_category.FormattingEnabled = true;
            this.cmbx_category.Location = new System.Drawing.Point(119, 75);
            this.cmbx_category.Margin = new System.Windows.Forms.Padding(4);
            this.cmbx_category.Name = "cmbx_category";
            this.cmbx_category.Size = new System.Drawing.Size(336, 24);
            this.cmbx_category.TabIndex = 0;
            this.cmbx_category.SelectedValueChanged += new System.EventHandler(this.cmbx_category_SelectedValueChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(663, 133);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(604, 313);
            this.dataGrid.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(923, 466);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Price:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(1084, 466);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(24, 25);
            this.lbl_price.TabIndex = 11;
            this.lbl_price.Text = "0";
            // 
            // btn_logadmin
            // 
            this.btn_logadmin.Location = new System.Drawing.Point(1066, 34);
            this.btn_logadmin.Name = "btn_logadmin";
            this.btn_logadmin.Size = new System.Drawing.Size(164, 48);
            this.btn_logadmin.TabIndex = 12;
            this.btn_logadmin.Text = "Log as admin";
            this.btn_logadmin.UseVisualStyleBackColor = true;
            this.btn_logadmin.Click += new System.EventHandler(this.btn_logadmin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 545);
            this.Controls.Add(this.btn_logadmin);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_category;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_logadmin;
        private System.Windows.Forms.Button btnComplete;
    }
}