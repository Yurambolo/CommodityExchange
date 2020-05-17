using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommodityExchange.Models;

namespace ExchangeApp
{
    public partial class ShowProductForm : Form
    {
        Product currentProduct;
        User Seller;

        public ShowProductForm(Product product, User seller)
        {
            InitializeComponent();
            currentProduct = product;
            Seller = seller;
        }

        private void ShowProductForm_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = currentProduct.Name;
            UnitTextBox.Text = currentProduct.Unit;
            RetailPriceTextBox.Text = currentProduct.RetailPrice.ToString();
            WholePriceTextBox.Text = currentProduct.WholePrice.ToString();
            MinimalWholeTextBox.Text = currentProduct.MinimalWhole.ToString();
            StockTextBox.Text = currentProduct.Stock.ToString();
            SellerTextBox.Text = Seller.Name;
        }

        private void SellerTextBox_DoubleClick(object sender, EventArgs e)
        {
            ShowUserForm suf = new ShowUserForm(Seller);
            suf.Show();
        }
    }
}
