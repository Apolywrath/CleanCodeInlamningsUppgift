using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopCleanCode
{
    public class ProductProxy
    {

        public string Name { get; set; }
        public int Price { get; set; }

        Database productDatabase;
        private Product product;
        public ProductProxy(string name, int price, Database database)
        {
            Name = name;
            Price = price;
            productDatabase= database;
        }

        public void Load()
        {
            if (product == null)
            {
                product = productDatabase.GetProductByName(Name);
            }
        }

        public int NrInStock
        {
            get { Load(); return product.NrInStock; }
            set { Load(); product.NrInStock = value; }
        }
        public bool InStock()
        {
            Load();
            return NrInStock > 0;
        }
        public void PrintInfo()
        {
            Load();
            Console.WriteLine(Name + ": " + Price + "kr, " + NrInStock + " in stock.");
        }
    }

}
