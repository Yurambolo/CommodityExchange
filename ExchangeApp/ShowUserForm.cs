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
    public partial class ShowUserForm : Form
    {
        public User currentUser;
        public ShowUserForm(User user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void ShowUserForm_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = currentUser.Name;
            PhoneTextBox.Text = currentUser.Phone;
            EmailTextBox.Text = currentUser.Email;
        }
    }
}
