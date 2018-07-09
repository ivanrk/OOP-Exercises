namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            try
            {
                var pizzaName = Console.ReadLine().Split()[1];
                var pizza = new Pizza(pizzaName);
                AddDough(pizza);
                AddTopping(pizza);

                Console.WriteLine($"{pizza.Name} - {pizza.CalculateCalories():f2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddTopping(Pizza pizza)
        {
            string toppingInfo;
            while ((toppingInfo = Console.ReadLine()) != "END")
            {
                var toppingArgs = toppingInfo.Split();
                var type = toppingArgs[1];
                var weight = decimal.Parse(toppingArgs[2]);
                var topping = new Topping(type, weight);
                pizza.AddTopping(topping);
            }
        }

        private static void AddDough(Pizza pizza)
        {
            var doughInfo = Console.ReadLine().Split();
            var flourType = doughInfo[1];
            var bakingTechnique = doughInfo[2];
            var weight = decimal.Parse(doughInfo[3]);
            pizza.AddDough(flourType, bakingTechnique, weight);
        }
    }
}
