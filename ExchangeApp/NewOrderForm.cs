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
    public partial class NewOrderForm : Form
    {
        User Seller;
        User Buyer;
        Product Product;

        public NewOrderForm(User seller, User buyer, Product product)
        {
            InitializeComponent();
            Product = product;
            Buyer = buyer;
            Seller = seller;
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            BuyerTextBox.Text = Buyer.Name;
            SellerTextBox.Text = Seller.Name;
            ProductTextBox.Text = Product.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public Order ReturnData()
        {
            return new Order(Buyer, Seller, Product, Convert.ToDouble(AmountTextBox.Text), Convert.ToDouble(PriceTextBox.Text), PayMethodComboBox.SelectedItem.ToString());
        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(AmountTextBox.Text);
            if (amount < Product.MinimalWhole)
                PriceTextBox.Text = (amount * Product.RetailPrice).ToString();
            else
                PriceTextBox.Text = (amount * Product.WholePrice).ToString();
        }
    }
}
