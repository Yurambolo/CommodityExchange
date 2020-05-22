using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityExchange.Models
{
    [Serializable]
    public class Order
    {
        public Guid Id { set; get; }
        public User Buyer { set; get; }
        public User Seller { set; get; }
        public Product Product { set; get; }
        public double Amount { set; get; }
        public double Price { set; get; }
        public DateTime DateTime { set; get; }
        public string PayMethod { set; get; }

        public Order() { }

        public Order(User buyer, User seller, Product product, double amount, double price, string paymethod, DateTime? t = null)
        {
            Id = Guid.NewGuid();
            Buyer = buyer;
            Seller = seller;
            Product = product;
            Amount = amount;
            Price = price;
            PayMethod = paymethod;
            if (t == null)
                DateTime = DateTime.Now;
            else
                DateTime = (DateTime)t;
        }

        public Order(Guid id, User buyer, User seller, Product product, double amount, double price, string paymethod, DateTime? t = null)
        {
            Id = id;
            Buyer = buyer;
            Seller = seller;
            Product = product;
            Amount = amount;
            Price = price;
            PayMethod = paymethod;
            if (t == null)
                DateTime = DateTime.Now;
            else
                DateTime = (DateTime)t;
        }
    }
}
