namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            try
            {
                var peopleInfo = Console.ReadLine().Split(new[] { '=', ';' });
                var productsInfo = Console.ReadLine().Split(new[] { '=', ';' });
                var people = new List<Person>();
                var products = new List<Product>();

                for (int i = 0; i < peopleInfo.Length - 1; i += 2)
                {
                    AddPerson(peopleInfo, people, i);
                }

                for (int i = 0; i < productsInfo.Length - 1; i += 2)
                {
                    AddProduct(productsInfo, products, i);
                }

                string commandLine;
                while ((commandLine = Console.ReadLine()) != "END")
                {
                    var command = commandLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    BuyProduct(people, products, command);
                }

                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddProduct(string[] productsInfo, List<Product> products, int i)
        {
            var name = productsInfo[i];
            var cost = decimal.Parse(productsInfo[i + 1]);
            var product = new Product(name, cost);
            products.Add(product);
        }

        private static void AddPerson(string[] peopleInfo, List<Person> people, int i)
        {
            var name = peopleInfo[i];
            var money = decimal.Parse(peopleInfo[i + 1]);
            var person = new Person(name, money);
            people.Add(person);
        }

        private static void BuyProduct(List<Person> people, List<Product> products, string[] command)
        {
            var name = command[0];
            var product = command[1];
            var currentPerson = people.Where(p => p.Name == name).FirstOrDefault();
            var currentProduct = products.Where(p => p.Name == product).FirstOrDefault();

            if (currentPerson.Money >= currentProduct.Cost)
            {
                currentPerson.Products.Add(currentProduct);
                currentPerson.Money -= currentProduct.Cost;
                Console.WriteLine($"{currentPerson.Name} bought { currentProduct.Name}");
            }
            else
            {
                Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
            }
        }
    }
}
