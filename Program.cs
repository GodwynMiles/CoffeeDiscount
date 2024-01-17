namespace CoffeeDiscount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, double> coffee = new Dictionary<string, double>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            foreach (string coffeeType in coffee.Keys.ToArray())
            {
                double discountedPrice = coffee[coffeeType] - coffee[coffeeType] * discount / 100;
                Console.WriteLine($"{coffeeType}: {discountedPrice}");
            }
        }
    }
}
