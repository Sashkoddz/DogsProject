namespace SuperMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperMarket<Food> foods = new SuperMarket<Food>();
            SuperMarket<Shoes> shoes = new SuperMarket<Shoes>();

            string[] foodsReader = Console.ReadLine().Split(';');
            string[] shoesReader = Console.ReadLine().Split(' ');

            for (int i = 0; i < foodsReader.Length; i++)
            {
                string[] foodInfo = foodsReader[0].Split('-');
                Food food = new Food(foodInfo[0], decimal.Parse(foodInfo[1]));
                foods.AddProduct(food,int.Parse(foodInfo[2]));
            }
            for (int i = 0; i < shoesReader.Length; i++)
            {
                string[] shoesInfo = shoesReader[0].Split('=');
                Shoes shoes1 = new Shoes(shoesInfo[0], decimal.Parse(shoesInfo[1]));
                shoes.AddProduct(shoes1, int.Parse(shoesInfo[2]));
            }

            string[] command = Console.ReadLine().Split();
            while (true)
            {
                if (command[0].ToLower() == "stop")
                {
                    Console.WriteLine($"There are {foods.Market.Values.Sum()} foods and {shoes.Market.Values.Sum()} shoes in the supermarket");
                    break;
                }
                if (command[0] == "Food")
                {
                    foreach (Food food in foods.Market.Keys.Where(food => food.Name == command[1]))
                    {
                        foods.BuyProduct(food, int.Parse(command[2]));
                        break;
                    }
                }
                else
                {
                    foreach (Shoes shoe in shoes.Market.Keys.Where(shoe => shoe.Name == command[1]))
                    {
                        shoes.BuyProduct(shoe, int.Parse(command[2]));
                        break;
                    }
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}