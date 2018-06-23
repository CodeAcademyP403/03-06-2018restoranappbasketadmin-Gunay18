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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private Form _Form;
        private List<ProductItem> _ProductItemList;
        private Staff _Staff;
        public ManagerForm(Form form, List<ProductItem> productItemList, Staff staff):this()
        {
            _Form = form;
            _ProductItemList = productItemList;
            _Staff = staff;
            FillOfficiants();
        }

        public void FillOfficiants()
        {
            List<String> OfficiantList = new List<String>();
            foreach (Person person in _Staff.StaffList)
            {
                if (person.Role == Role.Officant)
                {
                    OfficiantList.Add(person.Name);
                }
            }
            cmbx_officiants.DataSource = OfficiantList;
        }
        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Form.Close();
        }

        private void cmbx_officiants_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedOfficiantName = cmbx_officiants.SelectedValue.ToString();

            foreach (Person person in _Staff.StaffList)
            {
                if (person.Name == selectedOfficiantName)
                {
                    dataGridOrders.DataSource = person.Orders;
                }
            }
            //dataGridOrders.DataSource = _ProductItemList;
        }

        
    }
}
