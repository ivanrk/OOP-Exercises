namespace GenericBox
{
    using System;

    public class Box<T>
        where T : IComparable<T>
    {
        private T item;

        public Box(T item)
        {
            this.item = item;
        }

        public int CompareElementsCount(T givenElement)
        {
            var compareResult = this.item.CompareTo(givenElement);

            if (compareResult > 0)
            {
                return 1;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{this.item.GetType().FullName}: {this.item}";
        }
    }
}
