namespace WildFarm
{
    using System;
    using System.Collections.Generic;
    using WildFarm.Animals;
    using WildFarm.Foods;

    public class Startup
    {
        public static void Main()
        {
            var animals = new List<Animal>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                var input = inputLine.Split();
                Animal animal = null;
                Food food = null;

                var animalType = input[0];
                var name = input[1];
                var weight = double.Parse(input[2]);

                switch (animalType)
                {
                    case nameof(Owl):
                        animal = new Owl(name, weight, double.Parse(input[3]));
                        break;

                    case nameof(Hen):
                        animal = new Hen(name, weight, double.Parse(input[3]));
                        break;

                    case nameof(Mouse):
                        animal = new Mouse(name, weight, input[3]);
                        break;

                    case nameof(Dog):
                        animal = new Dog(name, weight, input[3]);
                        break;

                    case nameof(Cat):
                        animal = new Cat(name, weight, input[3], input[4]);
                        break;

                    case nameof(Tiger):
                        animal = new Tiger(name, weight, input[3], input[4]);
                        break;

                }

                inputLine = Console.ReadLine();
                input = inputLine.Split();

                var foodType = input[0];
                var quantity = int.Parse(input[1]);

                switch (foodType)
                {
                    case nameof(Vegetable):
                        food = new Vegetable(quantity);
                        break;

                    case nameof(Fruit):
                        food = new Fruit(quantity);
                        break;

                    case nameof(Meat):
                        food = new Meat(quantity);
                        break;

                    case nameof(Seeds):
                        food = new Seeds(quantity);
                        break;
                }

                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.EatFood(food);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                animals.Add(animal);
            }

            animals.ForEach(a => Console.WriteLine(a));
        }
    }
}


