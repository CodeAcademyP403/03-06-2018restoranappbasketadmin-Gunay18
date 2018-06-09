using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
           
        }
        private Form _Form;
        public List<ProductItem> ProductItemList=new List<ProductItem>();
        public LoginForm(Form form, List<ProductItem> productItemList ):this()
        {
            _Form = form;
            ProductItemList = productItemList;
        }
        Admin admin = new Admin();
        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txtbx_username.Text == admin.Username && txtbx_password.Text == admin.Password)
            {
                MessageBox.Show("Login is successful");
                this.Hide();
                AdminForm adminForm = new AdminForm(this, ProductItemList);
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Form.Close();
        }
    }
}
