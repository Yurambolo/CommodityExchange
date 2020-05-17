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
        Guid Seller;
        public NewProductForm(Guid seller)
        {
            InitializeComponent();
            Seller = seller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public Product ReturnData()
        {
            return new Product(NameTextBox.Text, UnitTextBox.Text, Convert.ToDecimal(RetailPriceTextBox.Text), Convert.ToDecimal(WholePriceTextBox.Text), Convert.ToDecimal(MinimalWholeTextBox.Text), Convert.ToDecimal(StockTextBox.Text), Seller);
        }
    }
}
