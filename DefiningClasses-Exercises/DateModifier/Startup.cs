namespace DateModifier
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var dates = new DateModifier(firstDate, secondDate);
            var datesDifference = dates.CalculateDatesDifference();
            Console.WriteLine(datesDifference);
        }
    }
}
