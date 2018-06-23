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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            FillRoles();
        }

        public void FillRoles()
        {
            cmbx_roles.DataSource = Enum.GetNames(typeof(Role));
        }

        private Form _Form;
        private List<ProductItem> _ProductItemList;
        private Staff _Staff = new Staff();
        public RegistrationForm(Form form, List<ProductItem> productItemList, Staff staff) :this()
        {
            _Form = form;
            _ProductItemList = productItemList;
            _Staff = staff;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Person Person = new Person()
            {
                Name = txtbx_name.Text,
                Email = txtbx_email.Text,
                Password = txtbx_password.Text,
                Role = (Role)Enum.Parse(typeof(Role), cmbx_roles.SelectedValue.ToString()),
                Orders = ((Role)Enum.Parse(typeof(Role), cmbx_roles.SelectedValue.ToString()) == Role.Officant) ? _ProductItemList : null
            };
            _Staff.StaffList.Add(Person);

            LoginForm loginForm = new LoginForm(this, _ProductItemList,_Staff);
            this.Hide();
            loginForm.Show();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Form.Close();
        }
    }
}
