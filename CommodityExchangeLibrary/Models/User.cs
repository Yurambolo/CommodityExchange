using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityExchange.Models
{
    [Serializable]
    public class User
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public string Password { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }

        public User() { }

        public User(string name, string password, string phone, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Password = password;
            Phone = phone;
            Email = email;
        }

        public User(Guid id, string name, string password, string phone, string email)
        {
            Id = id;
            Name = name;
            Password = password;
            Phone = phone;
            Email = email;
        }
    }
}
