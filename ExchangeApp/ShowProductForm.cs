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
        public Product CurrentProduct;
        User Seller;
        bool AllowEdit;
        bool editing = false;
        MainForm MainF;


        public ShowProductForm(Product product, User seller, bool allowEdit, MainForm mainf)
        {
            InitializeComponent();
            CurrentProduct = product;
            Seller = seller;
            AllowEdit = allowEdit;
            MainF = mainf;
        }

        private void ShowProductForm_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = CurrentProduct.Name;
            UnitTextBox.Text = CurrentProduct.Unit;
            RetailPriceTextBox.Text = CurrentProduct.RetailPrice.ToString();
            WholePriceTextBox.Text = CurrentProduct.WholePrice.ToString();
            MinimalWholeTextBox.Text = CurrentProduct.MinimalWhole.ToString();
            StockTextBox.Text = CurrentProduct.Stock.ToString();
            SellerTextBox.Text = Seller.Name;
            pictureBox1.Image = CurrentProduct.Image;
            if (AllowEdit)
            {
                EditButton.Visible = true;
                DeleteButton.Visible = true;
                OrderButton.Visible = false;
            }
        }

        private void SellerTextBox_DoubleClick(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().ToString() == "ExchangeApp.ShowUserForm")
                {
                    ShowUserForm Suf = (ShowUserForm)form;
                    if (Suf.currentUser.Id == Seller.Id)
                    {
                        Suf.Show();
                        Suf.Activate();
                        return;
                    }
                }
            }
            ShowUserForm suf = new ShowUserForm(Seller);
            suf.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            NameTextBox.ReadOnly = false;
            UnitTextBox.ReadOnly = false;
            RetailPriceTextBox.ReadOnly = false;
            WholePriceTextBox.ReadOnly = false;
            MinimalWholeTextBox.ReadOnly = false;
            StockTextBox.ReadOnly = false;
            pictureBox1.Enabled = true;
            EditButton.Enabled = false;
            SaveButton.Visible = true;
            CancelButton.Visible = true;
            editing = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = CurrentProduct.Name;
            UnitTextBox.Text = CurrentProduct.Unit;
            RetailPriceTextBox.Text = CurrentProduct.RetailPrice.ToString();
            WholePriceTextBox.Text = CurrentProduct.WholePrice.ToString();
            MinimalWholeTextBox.Text = CurrentProduct.MinimalWhole.ToString();
            StockTextBox.Text = CurrentProduct.Stock.ToString();
            pictureBox1.Image = CurrentProduct.Image;
            NameTextBox.ReadOnly = true;
            UnitTextBox.ReadOnly = true;
            RetailPriceTextBox.ReadOnly = true;
            WholePriceTextBox.ReadOnly = true;
            MinimalWholeTextBox.ReadOnly = true;
            StockTextBox.ReadOnly = true;
            pictureBox1.Enabled = false;
            EditButton.Enabled = true;
            SaveButton.Visible = false;
            CancelButton.Visible = false;
            editing = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }
        private bool Save()
        {
            
            if (!String.IsNullOrWhiteSpace(NameTextBox.Text) && !String.IsNullOrWhiteSpace(UnitTextBox.Text) && !String.IsNullOrWhiteSpace(RetailPriceTextBox.Text) && !String.IsNullOrWhiteSpace(WholePriceTextBox.Text) && !String.IsNullOrWhiteSpace(MinimalWholeTextBox.Text) && !String.IsNullOrWhiteSpace(StockTextBox.Text) && !(RetailPriceTextBox.Text[0] == ',') && !(RetailPriceTextBox.Text[RetailPriceTextBox.TextLength - 1] == ',') && !(WholePriceTextBox.Text[0] == ',') && !(WholePriceTextBox.Text[WholePriceTextBox.TextLength - 1] == ',') && !(MinimalWholeTextBox.Text[0] == ',') && !(MinimalWholeTextBox.Text[MinimalWholeTextBox.TextLength - 1] == ',') && !(StockTextBox.Text[0] == ',') && !(StockTextBox.Text[StockTextBox.TextLength - 1] == ','))
            {
                CurrentProduct.Name = NameTextBox.Text;
                CurrentProduct.Unit = UnitTextBox.Text;
                CurrentProduct.RetailPrice = Convert.ToDouble(RetailPriceTextBox.Text);
                CurrentProduct.WholePrice = Convert.ToDouble(WholePriceTextBox.Text);
                CurrentProduct.MinimalWhole = Convert.ToDouble(MinimalWholeTextBox.Text);
                CurrentProduct.Stock = Convert.ToDouble(StockTextBox.Text);
                CurrentProduct.Image = pictureBox1.Image;
                NameTextBox.ReadOnly = true;
                UnitTextBox.ReadOnly = true;
                RetailPriceTextBox.ReadOnly = true;
                WholePriceTextBox.ReadOnly = true;
                MinimalWholeTextBox.ReadOnly = true;
                StockTextBox.ReadOnly = true;
                pictureBox1.Enabled = false;
                EditButton.Enabled = true;
                SaveButton.Visible = false;
                CancelButton.Visible = false;
                MainF.CatalogueUpdate();
                MainF.MyProductsUpdate();
                MainF.IsDirty = true;
                editing = false;
                return true;
            }
            else
            {
                string message = "Fill all the fields";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                return false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Are you sure you want to delete this product?",
               "Question",
               MessageBoxButtons.YesNoCancel);

            switch (result)
            {
                case DialogResult.Yes:
                    {
                        break;
                    }
                case DialogResult.No:
                    {
                        return;
                    }
                case DialogResult.Cancel:
                    {
                        return;
                    }
            }
            MainF.exchange.Products.Remove(CurrentProduct);
            MainF.CatalogueUpdate();
            MainF.MyProductsUpdate();
            MainF.IsDirty = true;
            this.Close();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            NewOrderForm nof = new NewOrderForm(Seller, MainF.currentUser, CurrentProduct);
            nof.ShowDialog();
            if (nof.DialogResult == DialogResult.OK)
            {
                Order order = nof.ReturnData();
                MainF.exchange.Orders.Add(order);
                CurrentProduct.Stock -= order.Amount;
                MainF.CatalogueUpdate();
                MainF.MyProductsUpdate();
                MainF.MyOrdersUpdate();
                MainF.IsDirty = true;
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

        private void ShowProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editing)
            {
                DialogResult result = MessageBox.Show(
                "Save changes before quitting?",
                "Question",
                MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            if (!Save())
                                e.Cancel = true;
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
}
