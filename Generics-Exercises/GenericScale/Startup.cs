namespace GenericScale
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var scale = new Scale<int>(20, 5);
            Console.WriteLine(scale.GetHeavier());
        }
    }
}
