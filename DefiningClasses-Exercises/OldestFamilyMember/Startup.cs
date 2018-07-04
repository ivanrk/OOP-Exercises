namespace OldestFamilyMember
{
    using System;
    public class Startup
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < N; i++)
            {
                var inputLine = Console.ReadLine().Split();
                var name = inputLine[0];
                var age = int.Parse(inputLine[1]);

                var person = new Person(name, age);
                family.AddMember(person);
            }

            Console.WriteLine(family.GetOldestMember());
        }
    }
}
