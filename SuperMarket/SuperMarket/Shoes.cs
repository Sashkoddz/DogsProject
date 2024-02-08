using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class Shoes
    {
        private string name;
        private decimal price;

        public Shoes(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
