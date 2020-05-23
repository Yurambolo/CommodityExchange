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
    public partial class NewProductForm : Form
    {
        User Seller;
        public NewProductForm(User seller)
        {
            InitializeComponent();
            Seller = seller;
            pictureBox1.Image = new Bitmap("empty.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(NameTextBox.Text) && !String.IsNullOrWhiteSpace(UnitTextBox.Text) && !String.IsNullOrWhiteSpace(RetailPriceTextBox.Text) && !String.IsNullOrWhiteSpace(WholePriceTextBox.Text) && !String.IsNullOrWhiteSpace(MinimalWholeTextBox.Text) && !String.IsNullOrWhiteSpace(StockTextBox.Text) && !(RetailPriceTextBox.Text[0] == ',') && !(RetailPriceTextBox.Text[RetailPriceTextBox.TextLength-1] == ',') && !(WholePriceTextBox.Text[0] == ',') && !(WholePriceTextBox.Text[WholePriceTextBox.TextLength - 1] == ',') && !(MinimalWholeTextBox.Text[0] == ',') && !(MinimalWholeTextBox.Text[MinimalWholeTextBox.TextLength - 1] == ',') && !(StockTextBox.Text[0] == ',') && !(StockTextBox.Text[StockTextBox.TextLength - 1] == ','))
                this.DialogResult = DialogResult.OK;
            else
            {
                string message = "Fill all the fields";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                return;
            }
        }

        public Product ReturnData()
        {
            return new Product(NameTextBox.Text, UnitTextBox.Text, Convert.ToDouble(RetailPriceTextBox.Text), Convert.ToDouble(WholePriceTextBox.Text), Convert.ToDouble(MinimalWholeTextBox.Text), Convert.ToDouble(StockTextBox.Text), Seller, pictureBox1.Image);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
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
