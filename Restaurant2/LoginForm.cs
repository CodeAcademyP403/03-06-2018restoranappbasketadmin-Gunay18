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
            FillRoles();
        }

        public void FillRoles()
        {
            cmbx_roles.DataSource = Enum.GetNames(typeof(Role));
        }

        private Form _Form;
        public List<ProductItem> ProductItemList=new List<ProductItem>();
        public LoginForm(Form form, List<ProductItem> productItemList ):this()
        {
            _Form = form;
            ProductItemList = productItemList;
        }

        private Staff _Staff = new Staff();
        public LoginForm(Form form, List<ProductItem> productItemList, Staff staff):this()
        {
            _Form = form;
            ProductItemList = productItemList;
            _Staff = staff;
        }


        Person person = new Person();
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (_Staff.StaffList.Count == 0)
            {
                MessageBox.Show("No account is registered yet.");
                return;
            }
            
            foreach (Person item in _Staff.StaffList)
            {
                if (txtbx_username.Text == item.Name && txtbx_password.Text == item.Password && (Role)Enum.Parse(typeof(Role), cmbx_roles.SelectedValue.ToString())  == Role.Officant)
                {
                    MessageBox.Show("Login is successful");
                    this.Hide();
                    OfficiantForm officiantForm = new OfficiantForm(this, ProductItemList);
                    officiantForm.Show();
                    break;
                }
                else if (txtbx_username.Text == item.Name && txtbx_password.Text == item.Password && (Role)Enum.Parse(typeof(Role), cmbx_roles.SelectedValue.ToString()) == Role.Manager)
                {
                    MessageBox.Show("Login is successful");
                    this.Hide();
                    ManagerForm managerForm = new ManagerForm(this, ProductItemList, _Staff);
                    managerForm.Show();
                    break;
                }
                else if(_Staff.StaffList.IndexOf(item)==_Staff.StaffList.Count-1)
                {
                    MessageBox.Show("Login failed");
                }
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Form.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm(this, ProductItemList,_Staff);
            registrationForm.Show();
        }
    }
}
