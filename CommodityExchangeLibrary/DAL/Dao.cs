using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using CommodityExchange.Models;

namespace CommodityExchange.DAL
{
    public class Dao
    {
        Exchange exchange;
        const string filePath = "exchange.bin";

        public Dao(Exchange exchange)
        {
            this.exchange = exchange;
        }

        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, exchange);
            }
        }

        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                Exchange ex = (Exchange)serializer.Deserialize(stream);

                Copy(ex.Products, exchange.Products);
                Copy(ex.Users, exchange.Users);
                Copy(ex.Orders, exchange.Orders);
            }

            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }
    }
}
