namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public List<Product> Products
        {
            get { return this.products; }
            set { this.products = value; }
        }

        public override string ToString()
        {
            var output = $"{this.name} - ";
            var boughtProducts = new List<string>();
            foreach (var product in this.products)
            {
                boughtProducts.Add(product.Name);
            }

            if (boughtProducts.Count > 0)
                output += string.Join(", ", boughtProducts);
            else
                output += "Nothing bought";
          
            return output;
        }
    }
}
