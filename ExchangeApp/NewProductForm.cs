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
            pictureBox1.Image = new Bitmap("empty.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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
    }
}
