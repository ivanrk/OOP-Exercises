namespace ClassBox
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            try
            {
                var length = decimal.Parse(Console.ReadLine());
                var width = decimal.Parse(Console.ReadLine());
                var height = decimal.Parse(Console.ReadLine());

                var box = new Box(length, width, height);

                Console.WriteLine(box.CalculateSurfaceArea());
                Console.WriteLine(box.CalculateLateralSurfaceArea());
                Console.WriteLine(box.CalculateVolume());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
