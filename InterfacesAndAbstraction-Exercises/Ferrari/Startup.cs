namespace Ferrari
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var driver = Console.ReadLine();
            IDriveable ferrari = new Ferrari(driver);
            Console.WriteLine(ferrari);
        }
    }
}
