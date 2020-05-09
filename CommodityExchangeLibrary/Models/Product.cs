using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityExchange.Models
{
    [Serializable]
    public class Product
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public string Unit { set; get; }
        public decimal RetailPrice { set; get; }
        public decimal WholePrice { set; get; }
        public decimal MinimalWhole { set; get; }
        public decimal Stock { set; get; }
        public Guid SellerId { set; get; }

        public Product() { }

        public Product(string name, string unit, decimal retailPrice, decimal wholePrice, decimal minimalWhole, decimal stock, Guid seller)
        {
            Id = Guid.NewGuid();
            Name = name;
            Unit = unit;
            RetailPrice = retailPrice;
            WholePrice = wholePrice;
            MinimalWhole = minimalWhole;
            Stock = stock;
            SellerId = seller;
        }

        public Product(Guid id, string name, string unit, decimal retailPrice, decimal wholePrice, decimal minimalWhole, decimal stock, Guid seller)
        {
            Id = id;
            Name = name;
            Unit = unit;
            RetailPrice = retailPrice;
            WholePrice = wholePrice;
            MinimalWhole = minimalWhole;
            Stock = stock;
            SellerId = seller;
        }
    }
}
