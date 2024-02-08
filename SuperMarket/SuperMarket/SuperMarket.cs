using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class SuperMarket<T>
    {
        private Dictionary<T, int> market;

        public SuperMarket()
        {
            Market = new Dictionary<T, int>();
        }

        public SuperMarket(Dictionary<T, int> market)
        {
            this.Market = market;
        }

        public Dictionary<T, int> Market
        {
            get { return this.market; }
            set { this.market = value; }
        }

        public void AddProduct(T product, int quantity)
        {
            if (!market.ContainsKey(product))
            {
                market.Add(product, quantity);
            }
            else
            {
                market[product] += quantity;
            }
        }
        public void BuyProduct(T product, int quantity)
        {
            if (quantity > market[product])
            {
                Console.WriteLine("Not enough quantity!");
            }
            else
            {
                market[product] -= quantity;
                Console.WriteLine("You successfully bought a product.");
            }
        }
    }
}
