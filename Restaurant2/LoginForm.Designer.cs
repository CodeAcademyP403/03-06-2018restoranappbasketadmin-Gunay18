namespace Restaurant2
{
    partial class LoginForm
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
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbx_username
            // 
            this.txtbx_username.Location = new System.Drawing.Point(236, 87);
            this.txtbx_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(240, 22);
            this.txtbx_username.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // txtbx_password
            // 
            this.txtbx_password.Location = new System.Drawing.Point(236, 202);
            this.txtbx_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(240, 22);
            this.txtbx_password.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(283, 313);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(124, 37);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 444);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_username);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.Button btn_login;
    }
}

