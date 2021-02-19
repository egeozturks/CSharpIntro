using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var productsText = "Products";
            var addToCartButtonText = "Add To Cart";
            var cartText = "Your Cart";
            var removeFromCartButtonText = "Remove From Cart";

            lblProducts.Text = productsText;
            btnAddToCart.Text = addToCartButtonText;
            lbxCart.Text = cartText;
            btnRemoveFromCart.Text = removeFromCartButtonText;

            string[] products = new string[]
            {
                "Laptop", "Masaustu PC", "Klavye"
            };

            //for (int i = 0; i < products.Length; i++)
            //{
            //    lbxProducts.Items.Add(products[i]);
            //}

            foreach (var item in products)
            {
                lbxProducts.Items.Add(item);
            }

            if (lbxCart.Items.Count==0)
            {
                btnRemoveFromCart.Enabled = false;
            }

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lbxProducts.SelectedItem.ToString());

            if (lbxProducts.SelectedItem!=null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                btnRemoveFromCart.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please, choose a product");
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem!=null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please, choose a product");
                btnRemoveFromCart.Enabled = false;
            }
        }
    }
}
