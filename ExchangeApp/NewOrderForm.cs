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
            if (!(PayMethodComboBox.SelectedItem == null) && !String.IsNullOrWhiteSpace(PriceTextBox.Text) && !(PriceTextBox.Text[0] == ',') && !(PriceTextBox.Text[PriceTextBox.TextLength - 1] == ','))
            {
                if (Convert.ToDouble(AmountTextBox.Text) <= Product.Stock)
                    this.DialogResult = DialogResult.OK;
                else
                {
                    string message = "Inputed amout is bigger than availible stock";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    return;
                }
            }
            else
            {
                string message = "Fill all the fields";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                return;
            }
        }

        public Order ReturnData()
        {
            return new Order(Buyer, Seller, Product, Convert.ToDouble(AmountTextBox.Text), Convert.ToDouble(PriceTextBox.Text), PayMethodComboBox.SelectedItem.ToString());
        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            double amount;
            if (AmountTextBox.Text == "" || AmountTextBox.Text[0] == ',' || AmountTextBox.Text[AmountTextBox.TextLength - 1] == ',')
                amount = 0;
            else
                amount = Convert.ToDouble(AmountTextBox.Text);
            if (amount < Product.MinimalWhole)
                PriceTextBox.Text = (amount * Product.RetailPrice).ToString();
            else
                PriceTextBox.Text = (amount * Product.WholePrice).ToString();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            var tb = (TextBox)sender;
            if (tb.Text.Contains(',') && ch == ',')
                e.Handled = true;
            if (!Char.IsDigit(ch) && ch != 8 && ch != ',')
                e.Handled = true;
        }
    }
}
