namespace GenericArrayCreator
{
    public class Startup
    {
        public static void Main()
        {
            var strings = ArrayCreator.Create(5, "Pesho");
            var integers = ArrayCreator.Create(10, 33);
        }
    }
}
