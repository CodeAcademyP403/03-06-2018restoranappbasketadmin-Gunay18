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
    public partial class OfficiantForm : Form
    {
        public OfficiantForm()
        {
            InitializeComponent();
        }

        private Form _Form;
        private List<ProductItem> _ProductItemList=new List<ProductItem>();
        public OfficiantForm(Form form, List<ProductItem> productItemList):this()
        {
            _Form = form;
            _ProductItemList = productItemList;
            FillDataGrid();
        }
        public void FillDataGrid()
        {
            dataGridOrders.DataSource = _ProductItemList;
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Form.Close();
        }

       
    }
}
