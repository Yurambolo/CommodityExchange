using CommodityExchange.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityExchange.DAL
{
    public class Dao1
    {
        private readonly Exchange exchange;
        const string PRODUCTS = "products.txt";

        public Dao1(Exchange exchange)
        {
            this.exchange = exchange;
        }

        public void Save()
        {
            SaveProducts();
            SaveUsers();
            SaveOrders();
        }

        private void SaveProducts()
        {
            using (var wr = new StreamWriter(PRODUCTS))
            {
                wr.WriteLine(exchange.Products.Count);
                foreach (var p in exchange.Products)
                {
                    wr.WriteLine(p.Id);
                    wr.WriteLine(p.Name);
                    wr.WriteLine(p.Unit);
                    wr.WriteLine(p.RetailPrice);
                    wr.WriteLine(p.WholePrice);
                    wr.WriteLine(p.MinimalWhole);
                    wr.WriteLine(p.Stock);
                    wr.WriteLine(p.Seller);
                }
            }
        }

        private void SaveUsers()
        {
            using (var wr = new StreamWriter("users.txt"))
            {
                wr.WriteLine(exchange.Users.Count);
                foreach (var b in exchange.Users)
                {
                    wr.WriteLine(b.Id);
                    wr.WriteLine(b.Name);
                    wr.WriteLine(b.Password);
                    wr.WriteLine(b.Phone);
                    wr.WriteLine(b.Email);
                }
            }
        }

        private void SaveOrders()
        {
            using (var wr = new StreamWriter("orders.txt"))
            {
                wr.WriteLine(exchange.Orders.Count);
                foreach (var o in exchange.Orders)
                {
                    wr.WriteLine(o.Id);
                    wr.WriteLine(o.Buyer);
                    wr.WriteLine(o.Seller);
                    wr.WriteLine(o.Product);
                    wr.WriteLine(o.Amount);
                    wr.WriteLine(o.PayMethod);
                    wr.WriteLine(o.DateTime);
                }
            }
        }

        public void Load()
        {
            LoadProducts();
            LoadUsers();
            LoadOrders();
        }

        private void LoadProducts()
        {
            using (var rd = new StreamReader(PRODUCTS))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                exchange.Products.Clear();
                for (int i = 0; i < n; i++)
                {
                    exchange.Products.Add(new Product
                    {
                        Id = new Guid(rd.ReadLine()),
                        Name = rd.ReadLine(),
                        Unit = rd.ReadLine(),
                        RetailPrice = Convert.ToDouble(rd.ReadLine()),
                        WholePrice = Convert.ToDouble(rd.ReadLine()),
                        MinimalWhole = Convert.ToDouble(rd.ReadLine()),
                        Stock = Convert.ToDouble(rd.ReadLine()),
                        //Seller = new Guid(rd.ReadLine())
                    });
                }
            }
        }

        private void LoadUsers()
        {
            using (var rd = new StreamReader("buyers.txt"))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                exchange.Users.Clear();
                for (int i = 0; i < n; i++)
                {
                    exchange.Users.Add(new User
                    {
                        Id = new Guid(rd.ReadLine()),
                        Name = rd.ReadLine(),
                        Password = rd.ReadLine(),
                        Phone = rd.ReadLine(),
                        Email = rd.ReadLine()
                    });
                }
            }
        }

        private void LoadOrders()
        {
            using (var rd = new StreamReader("orders.txt"))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                exchange.Orders.Clear();
                for (int i = 0; i < n; i++)
                {
                    exchange.Orders.Add(new Order
                    {
                        Id = new Guid(rd.ReadLine()),
                        //Buyer = new Guid(rd.ReadLine()),
                        //Seller = new Guid(rd.ReadLine()),
                        //Product = new Guid(rd.ReadLine()),
                        Amount = Convert.ToInt32(rd.ReadLine()),
                        PayMethod = rd.ReadLine(),
                        DateTime = Convert.ToDateTime(rd.ReadLine())
                    });
                }
            }
        }      
    }
}
