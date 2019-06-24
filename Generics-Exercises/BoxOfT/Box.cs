namespace BoxOfT
{
    using System.Collections.Generic;
    using System.Linq;

    public class Box<T>
    {
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove()
        {
            var elementToRemove = this.data.Last();
            this.data.RemoveAt(this.data.Count - 1);
            return elementToRemove;
        }

        public int Count => this.data.Count;
    }
}
