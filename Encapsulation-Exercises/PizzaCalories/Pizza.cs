namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Pizza
    {
        private const int MIN_LENGHT = 1;
        private const int MAX_LENGTH = 15;
        private const int MAX_TOPPINGS = 10;

        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < MIN_LENGHT || value.Length > MAX_LENGTH)
                {
                    throw new ArgumentException($"Pizza name should be between {MIN_LENGHT} and {MAX_LENGTH} symbols.");
                }
                this.name = value;
            }
        }

        public void AddDough(string flourType, string bakingTechnique, decimal weight)
        {
            this.dough = new Dough(flourType, bakingTechnique, weight);
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count >= MAX_TOPPINGS)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..{MAX_TOPPINGS}].");
            }
            this.toppings.Add(topping);
        }

        public decimal CalculateCalories()
        {
            var doughCalories = this.dough.CalculateCalories();
            var totalCalories = doughCalories;
            foreach (var topping in this.toppings)
            {
                totalCalories += decimal.Parse(topping.CalculateCalories());
            }

            return totalCalories;
        }
    }
}
