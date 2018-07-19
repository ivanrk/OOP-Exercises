namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var occupants = new HashSet<IIdentifiable>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                var tokens = inputLine.Split();

                if (tokens.Length == 3)
                {
                    occupants.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
                else
                {
                    occupants.Add(new Robot(tokens[0], tokens[1]));
                }
            }

            var fakeIds = Console.ReadLine();
            occupants
                .Where(o => o.Id.EndsWith(fakeIds))
                .ToList()
                .ForEach(o => Console.WriteLine(o.Id));
        }
    }
}
