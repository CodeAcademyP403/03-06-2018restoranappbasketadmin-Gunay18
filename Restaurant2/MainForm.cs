using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Restaurant2
{
    public partial class MainForm : Form
    {
        
        private List<Product> products = new List<Product>();
        private List<ProductCategory> categories = new List<ProductCategory>();

        public MainForm()
        {
            InitializeComponent();
           // groupBox1.Hide();
            products.AddRange(new Product[]
            {
                new Product()
                {
                    Name="Dolma",
                    Price=7,
                    productCategory=ProductCategory.MainFood,
                    productID=1
                },

                 new Product()
                {
                    Name="Merci",
                    Price=3,
                    productCategory=ProductCategory.Soup,
                    productID=2
                },
                  new Product()
                {
                    Name="Pepsi",
                    Price=2,
                    productCategory=ProductCategory.Drinks,
                    productID=3
                },
                   new Product()
                {
                    Name="Akdeniz",
                    Price=2,
                    productCategory=ProductCategory.Salad,
                    productID=4
                },
                    new Product()
                {
                    Name="Kabab",
                    Price=7,
                    productCategory=ProductCategory.MainFood,
                    productID=5
                },
                     new Product()
                {
                    Name="Ayran",
                    Price=2,
                    productCategory=ProductCategory.Drinks,
                    productID=6
                },
                      new Product()
                {
                    Name="Tort",
                    Price=10,
                    productCategory=ProductCategory.Desserts,
                    productID=7
                },
            });
            loadCategory();
            AddStaff();

        }

        public void loadCategory()
        {
            cmbx_category.DataSource = Enum.GetValues(typeof(ProductCategory));
           
        }
        public Staff Staff = new Staff();

        public void AddStaff()
        {
            Staff.StaffList.AddRange(new Person[]
            {
                new Person
            {
                Name="Aydin",
                Email="aydin@gmail.com",
                Password="123",
                Role=Role.Officant
            },
                new Person
            {
                Name = "Gunel",
                Email = "gunel@gmail.com",
                Password = "123",
                Role = Role.Officant
            },
                new Person
            {
                Name = "Aydan",
                Email = "aydan@gmail.com",
                Password = "123",
                Role = Role.Officant
            },
                new Person
            {
                Name = "Aysel",
                Email = "aysel@gmail.com",
                Password = "123",
                Role = Role.Officant
            },
                new Person
            {
                Name = "Nadir",
                Email = "nadir@gmail.com",
                Password = "123",
                Role = Role.Manager
            },
                new Person
            {
                Name = "Sadiq",
                Email = "sadiq@gmail.com",
                Password = "123",
                Role = Role.Admin
            }
        });

        }

        public Basket basket = new Basket();
        private decimal totalPrice = 0;
        private void btn_order_Click(object sender, EventArgs e)
        {
            ProductItem productItem = new ProductItem();
            productItem.Name = cmbx_name.SelectedItem.ToString();
            productItem.Count = Convert.ToByte(txtbx_count.Text);
            productItem.TotalPrice = (Convert.ToDecimal(txtbx_price.Text)) * productItem.Count;
            foreach (Product item in products)
            {
                if (item.Name == productItem.Name)
                {
                    productItem.ID = item.productID;
                }
            }
            basket.ProductItems.Add(productItem);
           
            dataGrid.DataSource = null;
            dataGrid.DataSource = basket.ProductItems;
            totalPrice += productItem.TotalPrice;
            lbl_price.Text = totalPrice.ToString();
        }

        public List<ProductItem> Copy()
        {
         List<ProductItem> CopyOfOrders = new List<ProductItem>();

            foreach (ProductItem item in basket.ProductItems)
            {
                ProductItem productItem = new ProductItem()
                {
                    Count = item.Count,
                    ID = item.ID,
                    Name = item.Name,
                    TotalPrice = item.TotalPrice
                };
                CopyOfOrders.Add(productItem);
            }
            return CopyOfOrders;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            foreach (Person person in Staff.StaffList)
            {
                if (person.Role == Role.Officant && person.Orders == null)
                {
                    basket.Officiant = person;
                    //person.Orders = basket.ProductItems;
                    person.Orders = Copy();
                    break;
                }
            }
            //Orders.Add(basket.ProductItems);
            cmbx_category.SelectedIndex = 0;
            cmbx_name.SelectedIndex = 0;
            txtbx_count.Text = "1";
            txtbx_price.Text = "";
            dataGrid.DataSource = null;
            basket.ProductItems.RemoveAll(i => true);
        }

       
        // PROBLEM: MODIFING ARRAY AND REMOVEALL METHODS CHANGES PREVIOUS REFERENCES TO THAT ARRAY , 
        // INCLUDING THE ARRAY: PERSON.ORDERS

        private void cmbx_category_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((cmbx_category).SelectedItem != null)
            {
                ProductCategory selectedCategory = (ProductCategory)(cmbx_category).SelectedItem;
                cmbx_name.Items.Clear();
                foreach (Product item in products)
                {
                    if (selectedCategory == item.productCategory)
                    {
                        cmbx_name.Items.Add(item.Name);
                    }
                }
            }
        }

        private void cmbx_name_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cmbx_name.SelectedItem != null)
            {
                foreach (Product item in products)
                {
                    if (item.Name == cmbx_name.SelectedItem.ToString())
                    {
                        txtbx_price.Text = item.Price.ToString();
                    }
                }
            }
           
        }

        private void btn_logadmin_Click(object sender, EventArgs e)
        {
            //sending MainForm into LoginForm, so that when LoginForm closes, it closes MainForm too
            LoginForm loginForm = new LoginForm(this, basket.ProductItems, Staff);
            this.Hide();
            loginForm.Show();
            
        }

        //public List<List<ProductItem>> Orders = new List<List<ProductItem>>();

    }
}
