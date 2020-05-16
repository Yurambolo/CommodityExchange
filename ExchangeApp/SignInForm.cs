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
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            foreach (User user in exchange.Users)
            {
                if (user.Name == login)
                {
                    if (user.Password == password)
                    {
                        foreach(Form form in Application.OpenForms)
                        {
                            if (form.GetType().ToString() == "ExchangeApp.MainForm")
                            {
                                form.Show();
                                this.Hide();
                                return;
                            }
                        }
                        MainForm main = new MainForm();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password");
                    }
                    return;
                }
            }
            Console.WriteLine("User not found");
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            exchange.Load();
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
