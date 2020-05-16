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
    public partial class RegisterForm : Form
    {
        Exchange exchange = new Exchange();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            string password2 = PasswordTextBox2.Text;
            string phone = PhoneTextBox.Text;
            string email = EmailextBox.Text;
            if (password != password2)
            {
                string message = "Passwords are not the same";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                return;
            }
            foreach (User user in exchange.Users)
            {
                if (user.Name == login)
                {
                    string message = "User with this login already exists";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    return;
                }
                if (user.Phone == phone)
                {
                    string message = "User with this phone number already exists";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    return;
                }
                if (user.Email == email)
                {
                    string message = "User with this email already exists";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    return;
                }
            }
            User newUser = new User(login, password, phone, email);
            exchange.Users.Add(newUser);
            exchange.Save();
            MainForm main = new MainForm();
            main.Show();
            this.Hide();

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            exchange.Load();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason.ToString() == "UserClosing")
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignInForm sig = (SignInForm)Application.OpenForms[0];
            sig.Show();
            this.Hide();
        }
    }
}
