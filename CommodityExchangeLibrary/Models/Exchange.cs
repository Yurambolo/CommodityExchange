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

        public Product FindProductById(Guid Id)
        {
            foreach (Product product in Products)
            {
                if (product.Id == Id)
                    return product;
            }
            throw new Exception("Product Not Found");
        }

        public User FindUserById(Guid Id)
        {
            foreach (User user in Users)
            {
                if (user.Id == Id)
                    return user;
            }
            throw new Exception("User Not Found");
        }

        public Order FindOrderById(Guid Id)
        {
            foreach (Order order in Orders)
            {
                if (order.Id == Id)
                    return order;
            }
            throw new Exception("ProductNotFound");
        }
    }
}
