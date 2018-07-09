namespace PizzaCalories
{
    using System;

    public class Dough
    {
        private const int MIN_WEIGHT = 1;
        private const int MAX_WEIGHT = 200;

        private string flourType;
        private string bakingTechnique;
        private decimal weight;

        public Dough(string flourType, string bakingTechnique, decimal weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get { return this.flourType; }
            private set
            {
                value = ConvertToTitleCase(value);

                if (value != "White" && value != "Wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get { return this.bakingTechnique; }
            private set
            {
                value = ConvertToTitleCase(value);

                if (value != "Crispy" && value != "Chewy" && value != "Homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }

        public decimal Weight
        {
            get { return this.weight; }
            private set
            {
                if (value < MIN_WEIGHT || value > MAX_WEIGHT)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
                }
                this.weight = value;
            }
        }

        public static string ConvertToTitleCase(string value)
        {
            value = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            return value;
        }

        public decimal CalculateCalories()
        {
            decimal flourTypeModifier, bakingtechniqueModifier;
            AssignModifiers(out flourTypeModifier, out bakingtechniqueModifier);
            return 2 * this.weight * flourTypeModifier * bakingtechniqueModifier;
        }

        private void AssignModifiers(out decimal flourTypeModifier, out decimal bakingtechniqueModifier)
        {
            flourTypeModifier = 0.0m;
            bakingtechniqueModifier = 0.0m;
            switch (this.flourType)
            {
                case "White": flourTypeModifier = 1.5m; break;
                case "Wholegrain": flourTypeModifier = 1.0m; break;
            }
            switch (this.bakingTechnique)
            {
                case "Crispy": bakingtechniqueModifier = 0.9m; break;
                case "Chewy": bakingtechniqueModifier = 1.1m; break;
                case "Homemade": bakingtechniqueModifier = 1.0m; break;
            }
        }
    }
}
