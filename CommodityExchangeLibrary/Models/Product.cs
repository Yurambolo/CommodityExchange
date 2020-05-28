using System;
using System.Drawing;
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
        public double RetailPrice { set; get; }
        public double WholePrice { set; get; }
        public double MinimalWhole { set; get; }
        public double Stock { set; get; }
        public User Seller { set; get; } 
        public Image Image { set; get; }

        public Product(string name, string unit, double retailPrice, double wholePrice, double minimalWhole, double stock, User seller, Image image)
        {
            Id = Guid.NewGuid();
            Name = name;
            Unit = unit;
            RetailPrice = retailPrice;
            WholePrice = wholePrice;
            MinimalWhole = minimalWhole;
            Stock = stock;
            Seller = seller;
            Image = image;
        }
    }
}
