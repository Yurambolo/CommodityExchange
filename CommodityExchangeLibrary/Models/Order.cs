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
        public Guid BuyerId { set; get; }
        public Guid SellerId { set; get; }
        public Guid ProductId { set; get; }
        public double Amount { set; get; }
        public DateTime DateTime { set; get; }
        public string PayMethod { set; get; }

        public Order() { }

        public Order(Guid buyer, Guid seller, Guid product, double amount, string paymethod, DateTime? t = null)
        {
            Id = Guid.NewGuid();
            BuyerId = buyer;
            SellerId = seller;
            ProductId = product;
            Amount = amount;
            PayMethod = paymethod;
            if (t == null)
                DateTime = DateTime.Now;
            else
                DateTime = (DateTime)t;
        }

        public Order(Guid id, Guid buyer, Guid seller, Guid product, double amount, string paymethod, DateTime? t = null)
        {
            Id = id;
            BuyerId = buyer;
            SellerId = seller;
            ProductId = product;
            Amount = amount;
            PayMethod = paymethod;
            if (t == null)
                DateTime = DateTime.Now;
            else
                DateTime = (DateTime)t;
        }
    }
}
