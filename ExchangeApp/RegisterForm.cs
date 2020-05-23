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
            exchange.Load();
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            string password2 = PasswordTextBox2.Text;
            string phone = PhoneTextBox.Text;
            string email = EmailextBox.Text;
            if (String.IsNullOrWhiteSpace(login) || String.IsNullOrWhiteSpace(password))
            {
                string message = "Fill all the fields";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                return;
            }
            if (phone.Length < 10 || phone.Length > 13)
            {
                string message = "Phone number format should be '+380*********'";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                return;
            }
            if (email.IndexOf("@") < 1 || email.LastIndexOf('@') != email.IndexOf("@"))
            {
                string message = "E-mail format should be 'example@rambler.com'";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                return;
            }
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
            MainForm main;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().ToString() == "ExchangeApp.MainForm")
                {
                    main = (MainForm)form;
                    main.currentUser = newUser;
                    main.Show();
                    main.FormUpdate();
                    this.Hide();
                    return;
                }
            }
            main = new MainForm();
            main.currentUser = newUser;
            main.Show();
            this.Hide();

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
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

        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (PhoneTextBox.Text.Length == 1 && ch == 8)
                e.Handled = true;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;            
        }
    }
}
