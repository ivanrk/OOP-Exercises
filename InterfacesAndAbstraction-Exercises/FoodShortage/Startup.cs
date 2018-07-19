namespace FoodShortage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var people = new List<IBuyer>();
            var numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var inputLine = Console.ReadLine().Split();

                if (inputLine.Length == 4)
                {
                    people.Add(new Citizen(inputLine[0], int.Parse(inputLine[1]), inputLine[2], inputLine[3]));
                }
                else if (inputLine.Length == 3)
                {
                    people.Add(new Rebel(inputLine[0], int.Parse(inputLine[1]), inputLine[2]));
                }
            }

            string buyer;
            while ((buyer = Console.ReadLine()) != "End")
            {
                if (people.Any(b => b.Name == buyer))
                {
                    var currentBuyer = people.Where(b => b.Name == buyer).FirstOrDefault();
                    currentBuyer.BuyFood();
                }
            }

            Console.WriteLine(people.Sum(p => p.Food)); 
        }
    }
}
