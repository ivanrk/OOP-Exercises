namespace CustomList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomList<T> : IEnumerable
        where T : IComparable<T>
    {
        private List<T> elements;

        public CustomList()
        {
            this.elements = new List<T>();
        }

        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public T Remove(int index)
        {
            var element = this.elements[index];
            this.elements.RemoveAt(index);

            return element;
        }

        public bool Contains(T element)
        {
            if (this.elements.Contains(element))
            {
                return true;
            }

            return false;
        }

        public void Sort() => this.elements.Sort();

        public void Swap(int index, int withIndex)
        {
            var element = this.elements[index];
            this.elements[index] = this.elements[withIndex];
            this.elements[withIndex] = element;
        }

        public int CountGreaterThan(T element) => this.elements.Where(e => e.CompareTo(element) > 0).Count();

        public T Max() => this.elements.Max();

        public T Min() => this.elements.Min();

        public IEnumerator GetEnumerator()
        {
            return this.elements.GetEnumerator();
        }
    }
}
