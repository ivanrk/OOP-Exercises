namespace BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var livingBeings = new HashSet<IBirthable>();

            string inputline;
            while ((inputline = Console.ReadLine()) != "End")
            {
                var tokens = inputline.Split();
                if (tokens[0] == "Citizen")
                {
                    livingBeings.Add(new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]));
                }
                else if(tokens[0] == "Pet")
                {
                    livingBeings.Add(new Pet(tokens[1], tokens[2]));
                }
            }

            var year = Console.ReadLine();
           
            livingBeings
                .Where(b => b.BirthDate.EndsWith(year))
                .ToList()
                .ForEach(b => Console.WriteLine(b.BirthDate));
        }
    }
}
