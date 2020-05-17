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
        User user;
        public ShowUserForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ShowUserForm_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = user.Name;
            PhoneTextBox.Text = user.Phone;
            EmailTextBox.Text = user.Email;
        }
    }
}
