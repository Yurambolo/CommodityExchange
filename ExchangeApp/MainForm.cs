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

        public Exchange exchange = new Exchange();
        public User currentUser;
        public bool IsDirty = false;

        public MainForm()
        {
            InitializeComponent();
        }

        public void CatalogueUpdate()
        {
            CatalogueGridView.Rows.Clear();
            foreach (Product product in exchange.Products)
            {
                string[] row = { product.Id.ToString(), product.Name, product.Unit, product.RetailPrice.ToString(), product.WholePrice.ToString(), product.MinimalWhole.ToString(), product.Stock.ToString(), product.Seller.Name.ToString() };
                CatalogueGridView.Rows.Add(row);
            }
        }

        public void MyProductsUpdate()
        {
            MyProductsGridView.Rows.Clear();
            foreach (Product product in exchange.Products)
            {
                if (product.Seller.Id == currentUser.Id)
                {
                    string[] row = { product.Id.ToString(), product.Name, product.Unit, product.RetailPrice.ToString(), product.WholePrice.ToString(), product.MinimalWhole.ToString(), product.Stock.ToString(), product.Seller.Name.ToString() };
                    MyProductsGridView.Rows.Add(row);
                }
            }
        }

        public void MyOrdersUpdate()
        {
            MyOrdersGridView.Rows.Clear();
            foreach (Order order in exchange.Orders)
            {
                if (order.Seller.Id == currentUser.Id || order.Buyer.Id == currentUser.Id)
                {
                    string[] row = { order.Id.ToString(), order.Buyer.Name, order.Seller.Name, order.Product.Name, order.Amount.ToString(), order.Price.ToString(), order.DateTime.ToString(), order.PayMethod};
                    MyOrdersGridView.Rows.Add(row);
                }
            }
        }

        public void FormUpdate()
        {
            exchange.Load();
            CatalogueUpdate();
            MyProductsUpdate();
            MyOrdersUpdate();
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
            FormUpdate();      
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show(
           "Save changes before quitting?",
           "Question",
           MessageBoxButtons.YesNoCancel);

            switch (result)
            {
                case DialogResult.Yes:
                    {
                        exchange.Save();
                        IsDirty = false;
                        break;
                    }
                case DialogResult.No:
                    {
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        return;
                    }
            }
            SignInForm sig = (SignInForm)Application.OpenForms[0];
            sig.Show();
            this.Hide();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exchange.Save();
            IsDirty = false;
        }

        private void CatalogueGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Product currentProduct = exchange.FindProductById(new Guid(CatalogueGridView.CurrentRow.Cells[idDataGridViewTextBoxColumn2.Name].Value.ToString()));
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().ToString() == "ExchangeApp.ShowProductForm")
                {
                    ShowProductForm Spf = (ShowProductForm)form;
                    if (Spf.CurrentProduct.Id == currentProduct.Id)
                    {
                        Spf.Show();
                        Spf.Activate();
                        return;
                    }
                }
            }
            User seller = currentProduct.Seller;
            ShowProductForm spf = new ShowProductForm(currentProduct, seller, seller.Id == currentUser.Id, this);
            spf.Show();
        }

        private void MyProductsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Product currentProduct = exchange.FindProductById(new Guid(MyProductsGridView.CurrentRow.Cells[dataGridViewTextBoxColumn1.Name].Value.ToString()));
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().ToString() == "ExchangeApp.ShowProductForm")
                {
                    ShowProductForm Spf = (ShowProductForm)form;
                    if (Spf.CurrentProduct.Id == currentProduct.Id)
                    {
                        Spf.Show();
                        Spf.Activate();
                        return;
                    }
                }
            }
            User seller = currentProduct.Seller;
            ShowProductForm spf = new ShowProductForm(currentProduct, seller, seller.Id == currentUser.Id, this);
            spf.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProductForm npf = new NewProductForm(currentUser);
            npf.ShowDialog();
            if (npf.DialogResult == DialogResult.OK)
            {
                exchange.Products.Add(npf.ReturnData());
                CatalogueUpdate();
                MyProductsUpdate();
                IsDirty = true;
            }
        }

        private void showCurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (tabControl1.SelectedIndex != 2)
            {
                Product currentProduct;
                if (tabControl1.SelectedIndex == 0)
                    currentProduct = exchange.FindProductById(new Guid(CatalogueGridView.CurrentRow.Cells[idDataGridViewTextBoxColumn2.Name].Value.ToString()));
                else
                    currentProduct = exchange.FindProductById(new Guid(MyProductsGridView.CurrentRow.Cells[dataGridViewTextBoxColumn1.Name].Value.ToString()));
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType().ToString() == "ExchangeApp.ShowProductForm")
                    {
                        ShowProductForm Spf = (ShowProductForm)form;
                        if (Spf.CurrentProduct.Id == currentProduct.Id)
                        {
                            Spf.Show();
                            Spf.Activate();
                            return;
                        }
                    }
                }
                User seller = currentProduct.Seller;
                ShowProductForm spf = new ShowProductForm(currentProduct, seller, seller.Id == currentUser.Id, this);
                spf.Show();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Save changes before quitting?",
            "Question",
            MessageBoxButtons.YesNoCancel);

            switch (result)
            {
                case DialogResult.Yes:
                    {
                        exchange.Save();
                        IsDirty = false;
                        break;
                    }
                case DialogResult.No:
                    {
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        e.Cancel = true;
                        break;
                    }
            }
        }
    }
}
