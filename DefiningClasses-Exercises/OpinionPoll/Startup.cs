namespace OpinionPoll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            for (int i = 0; i < N; i++)
            {
                var inputLine = Console.ReadLine().Split();
                var name = inputLine[0];
                var age = int.Parse(inputLine[1]);

                var person = new Person(name, age);
                people.Add(person);
            }

            var olderThan30 = people.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();

            foreach (var person in olderThan30)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
