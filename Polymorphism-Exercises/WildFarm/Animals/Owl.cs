namespace WildFarm.Animals
{
    using System;
    using WildFarm.Foods;

    public class Owl : Bird
    {
        private const double WeightIncreaseModifier = 0.25;

        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override double WeightIncrease => WeightIncreaseModifier;

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }

        public override void EatFood(Food food)
        {
            var foodType = food.GetType().Name;
            var quantity = food.Quantity;

            if (foodType != nameof(Meat))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {foodType}!");
            }

            var weightIncrease = quantity * WeightIncrease;
            this.Weight += weightIncrease;
            this.FoodEaten += quantity;
        }
    }
}
