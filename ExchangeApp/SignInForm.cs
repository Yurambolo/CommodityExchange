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
                        Console.WriteLine("Incorrect password");
                    }
                    return;
                }
            }
            Console.WriteLine("User not found");
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
