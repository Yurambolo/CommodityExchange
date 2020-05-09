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

namespace CommodityExchange
{
    public partial class Form1 : Form
    {

        Exchange exchange = new Exchange();

        public Form1()
        {
            InitializeComponent();
        }

        private void exchangeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //exchange.Load();
            exchange.Users.Add(new User("Vasya","123","0123189","123@mail.ru"));
            exchange.Users.Add(new User("Fedya", "321", "9172983", "321@mail.ru"));
            exchange.Products.Add(new Product("1", "in", 400, 300, 12, 100, exchange.Users[0].Id));
            exchange.Orders.Add(new Order(exchange.Users[0].Id, exchange.Users[1].Id, exchange.Products[0].Id, 2, "123"));
            foreach (Product product in exchange.Products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.RetailPrice);
                Console.WriteLine(product.WholePrice);
                Console.WriteLine(product.Unit);
                Console.WriteLine(product.MinimalWhole);
            }
            exchange.Save();
            new DAL.Dao1(exchange).Save();
        }
    }
}
