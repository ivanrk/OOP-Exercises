namespace Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var people = new List<Person>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                var inputInfo = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var personName = inputInfo[0];

                if (!people.Any(p => p.Name == personName))
                {
                    people.Add(new Person(personName));
                }

                var currentLineInfo = inputInfo[1];
                var person = people.Where(p => p.Name == personName).FirstOrDefault();
                CheckCurrentLineInfo(inputInfo, currentLineInfo, person);
            }

            inputLine = Console.ReadLine();
            var currPerson = people.Where(p => p.Name == inputLine).First();
            PrintInfo(currPerson);
        }

        private static void CheckCurrentLineInfo(string[] inputInfo, string currentLineInfo, Person person)
        {
            if (currentLineInfo == "company")
            {
                var companyName = inputInfo[2];
                var department = inputInfo[3];
                var salary = decimal.Parse(inputInfo[4]);
                person.Company = new Company(companyName, department, salary);
            }
            else if (currentLineInfo == "pokemon")
            {
                var pokemonName = inputInfo[2];
                var pokemonType = inputInfo[3];
                person.Pokemons.Add(new Pokemon(pokemonName, pokemonType));
            }
            else if (currentLineInfo == "parents")
            {
                var parentName = inputInfo[2];
                var parentBirthday = inputInfo[3];
                person.Parents.Add(new Parent(parentName, parentBirthday));
            }
            else if (currentLineInfo == "children")
            {
                var childName = inputInfo[2];
                var childBirthday = inputInfo[3];
                person.Children.Add(new Child(childName, childBirthday));
            }
            else if (currentLineInfo == "car")
            {
                var carModel = inputInfo[2];
                var carSpeed = int.Parse(inputInfo[3]);
                person.Car = new Car(carModel, carSpeed);
            }
        }

        private static void PrintInfo(Person currPerson)
        {
            Console.WriteLine(currPerson.Name);

            if (currPerson.Company == null)
                Console.WriteLine("Company:");
            else
                Console.WriteLine(currPerson.Company);

            if (currPerson.Car == null)
                Console.WriteLine("Car:");
            else
                Console.WriteLine(currPerson.Car);

            Console.WriteLine("Pokemon:");
            currPerson.Pokemons.ForEach(p => Console.WriteLine(p));
            Console.WriteLine("Parents:");
            currPerson.Parents.ForEach(p => Console.WriteLine(p));
            Console.WriteLine("Children:");
            currPerson.Children.ForEach(c => Console.WriteLine(c));
        }
    }
}
