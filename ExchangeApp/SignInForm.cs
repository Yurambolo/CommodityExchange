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
    public partial class SignInForm : Form
    {

        Exchange exchange = new Exchange();

        public SignInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exchange.Load();
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            if (!String.IsNullOrWhiteSpace(login) && !String.IsNullOrWhiteSpace(password))
            {
                foreach (User user in exchange.Users)
                {
                    if (user.Name == login)
                    {
                        if (user.Password == password)
                        {
                            MainForm main;
                            foreach (Form form in Application.OpenForms)
                            {
                                if (form.GetType().ToString() == "ExchangeApp.MainForm")
                                {
                                    main = (MainForm)form;
                                    main.currentUser = user;
                                    main.Show();
                                    main.FormUpdate();
                                    this.Hide();
                                    return;
                                }
                            }
                            main = new MainForm();
                            main.currentUser = user;
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            string message1 = "Incorrect password";
                            string caption1 = "Error Detected in Input";
                            MessageBoxButtons buttons1 = MessageBoxButtons.OK;
                            DialogResult result1;

                            // Displays the MessageBox.
                            result1 = MessageBox.Show(message1, caption1, buttons1);
                            return;
                        }
                        return;
                    }
                }
                string message = "User not found";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                return;
            }
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

        private void SignInForm_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().ToString() == "ExchangeApp.RegisterForm")
                {
                    form.Show();
                    this.Hide();
                    return;
                }
            }
            RegisterForm reg = new RegisterForm();
            reg.Show();
            this.Hide();
        }

    }
}
