using BLL.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Sell
{
    public partial class Cart : Form
    {
        private List<Product> _order;
        Product pr = new Product();

        Dictionary<Product, int> ord = new Dictionary<Product, int>();
        public Cart(List<Product> order)
        {
            InitializeComponent();
            _order = order;
        }
        double total = 0;
        string pname = "";
        private void Cart_Load(object sender, EventArgs e)
        {
            foreach (Product product in _order)
            {
                total = total + product.UnitPrice;
                pname = product.ProductName;
                listBox1.Items.Add(pname + " : " + product.UnitPrice + "\n");
                lblTotalPrice.Text = total.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categories ct = new Categories(_order);
            ct.Show();
            this.Hide();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            int secim = listBox1.SelectedIndex;

            if (secim != -1)
            {

                string s = listBox1.Items[secim].ToString().Split(':')[0].Trim();
                Product pr = _order.FirstOrDefault(o => o.ProductName == s);
                listBox1.Items.RemoveAt(secim);

                _order.Remove(pr);

                total = 0;
                foreach (Product product in _order)
                    total = total + product.UnitPrice;

                lblTotalPrice.Text = total.ToString();

            }
            else
            {
                MessageBox.Show("Make a selection first !");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lblTotalPrice.Text = "--";
            _order.Clear();
        }
        Order or = new Order();
        OrderManager order = new OrderManager();
        ProductManager pm;
      
        private void btnPay_Click(object sender, EventArgs e)
        {
            or = new Order();
            pm = new ProductManager();

           
            #region  cozum
            try
            {
                foreach (Product item in _order)
                {
                    if (ord.ContainsKey(item))
                    {
                        ord[item] = ord[item] + 1;  
                    }
                    else
                    {
                        ord[item] = 1;
                    }

                }

                foreach (var item in ord)
                {

                    Product k = item.Key;
                    int v = item.Value;
                    //string name = k.ProductName;
                    //or.ProductName = name;
                    or.ProductName = k.ProductName;
                    or.ProductId = pm.ListBll().FirstOrDefault(p => p.ProductName == k.ProductName).Id;
                    or.Quantity = v;
                    or.Unitprice = pm.ListBll().FirstOrDefault(p => p.UnitPrice == k.UnitPrice).UnitPrice;
                    or.Quantity = v;
                    or.OrderDate = DateTime.Now;
                    order.AddBll(or);
                }
                listBox1.Items.Clear();
                lblTotalPrice.Text = "";
                MessageBox.Show("Payment successful !");
            }
            catch (Exception)
            {

                MessageBox.Show("Payment failed !");
            }
            #endregion


        }
    }
}
