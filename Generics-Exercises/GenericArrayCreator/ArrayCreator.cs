namespace GenericArrayCreator
{
    public class ArrayCreator
    {

        public static T[] Create<T>(int length, T item)
        {
            var data = new T[length];

            for (int i = 0; i < length; i++)
            {
                data[i] = item;
            }

            return data;
        }
    }
}
