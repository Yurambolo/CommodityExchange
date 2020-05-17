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
using CommodityExchange.DAL;

namespace ExchangeApp
{
    public partial class MainForm : Form
    {

        Exchange exchange = new Exchange();
        public User currentUser;

        public MainForm()
        {
            InitializeComponent();
        }

        private void CatalogueUpdate()
        {
            CatalogueGridView.Rows.Clear();
            foreach (Product product in exchange.Products)
            {
                string[] row = { product.Id.ToString(), product.Name, product.Unit, product.RetailPrice.ToString(), product.WholePrice.ToString(), product.MinimalWhole.ToString(), product.Stock.ToString(), product.SellerId.ToString() };
                CatalogueGridView.Rows.Add(row);
            }
        }

        private void MyProductsUpdate()
        {
            MyProductsGridView.Rows.Clear();
            foreach (Product product in exchange.Products)
            {
                if (product.SellerId == currentUser.Id)
                {
                    string[] row = { product.Id.ToString(), product.Name, product.Unit, product.RetailPrice.ToString(), product.WholePrice.ToString(), product.MinimalWhole.ToString(), product.Stock.ToString(), product.SellerId.ToString() };
                    MyProductsGridView.Rows.Add(row);
                }
            }
        }

        private void exchangeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }               

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason.ToString() == "UserClosing")
                Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            exchange.Load();
            CatalogueUpdate();
            MyProductsUpdate();            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignInForm sig = (SignInForm)Application.OpenForms[0];
            sig.Show();
            this.Hide();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exchange.Save();
            Dao1 dao1 = new Dao1(exchange);
            dao1.Save();
        }

        private void CatalogueGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Product currentProduct = exchange.Products[e.RowIndex];
            User seller = exchange.FindUserById(currentProduct.SellerId);
            ShowProductForm spf = new ShowProductForm(currentProduct, seller);
            spf.Show();
        }

        private void MyProductsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Product currentProduct = exchange.Products[e.RowIndex];
            User seller = exchange.FindUserById(currentProduct.SellerId);
            ShowProductForm spf = new ShowProductForm(currentProduct, seller);
            spf.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProductForm npf = new NewProductForm(currentUser.Id);
            npf.ShowDialog();
            if (npf.DialogResult == DialogResult.OK)
            {
                exchange.Products.Add(npf.ReturnData());
                CatalogueUpdate();
                MyProductsUpdate();
            }
        }

        private void showCurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (tabControl1.SelectedIndex != 2)
            {
                Product currentProduct;
                if (tabControl1.SelectedIndex == 0)
                    currentProduct = exchange.Products[CatalogueGridView.CurrentRow.Index];
                else
                    currentProduct = exchange.Products[MyProductsGridView.CurrentRow.Index];
                User seller = exchange.FindUserById(currentProduct.SellerId);
                ShowProductForm spf = new ShowProductForm(currentProduct, seller);
                spf.Show();
            }
        }

        
    }
}
