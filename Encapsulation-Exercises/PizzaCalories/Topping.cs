namespace PizzaCalories
{
    using System;

    public class Topping 
    {
        private const int MIN_WEIGHT = 1;
        private const int MAX_WEIGHT = 50;

        private string type;
        private decimal weight;

        public Topping(string type, decimal weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get { return this.type; }
            private set
            {
                value = ConvertToTitleCase(value);

                if (value != "Meat" && value != "Veggies" && value != "Cheese" && value != "Sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.type = value;
            }
        }

        public decimal Weight
        {
            get { return this.weight; }
            private set
            {
                if (value < MIN_WEIGHT || value > MAX_WEIGHT)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
                }
                this.weight = value;
            }
        }

        public static string ConvertToTitleCase(string value)
        {
            value = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            return value;
        }

        public string CalculateCalories()
        {
            var toppingTypeModifier = AssignToppingModifier();
            var calories = 2 * this.weight * toppingTypeModifier;
            return $"{calories:f2}";
        }

        private decimal AssignToppingModifier()
        {
            var toppingTypeModifier = 0.0m;
            switch (this.type)
            {
                case "Meat": toppingTypeModifier = 1.2m; break;
                case "Veggies": toppingTypeModifier = 0.8m; break;
                case "Cheese": toppingTypeModifier = 1.1m; break;
                case "Sauce": toppingTypeModifier = 0.9m; break;
            }

            return toppingTypeModifier;
        }
    }
}
