using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommodityExchange.DAL;

namespace CommodityExchange.Models
{
    [Serializable]
    public class Exchange
    {
        public List<Product> Products { private set; get; }
        public List<User> Users { private set; get; }
        public List<Order> Orders { private set; get; }

        public Exchange()
        {
            Products = new List<Product>();
            Users = new List<User>();
            Orders = new List<Order>();
        }
        
        public void Save()
        {
            new Dao(this).Save();
        }

        public void Load()
        {
            new Dao(this).Load();
        }

    }
}
