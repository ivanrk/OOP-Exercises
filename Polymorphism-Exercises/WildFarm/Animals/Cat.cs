namespace WildFarm.Animals
{
    using System;
    using WildFarm.Foods;

    public class Cat : Feline
    {
        private const double WeightIncreaseModifier = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightIncrease => WeightIncreaseModifier;

        public override string ProduceSound()
        {
            return "Meow";
        }

        public override void EatFood(Food food)
        {
            var foodType = food.GetType().Name;
            var quantity = food.Quantity;

            if (foodType != nameof(Vegetable) && foodType != nameof(Meat))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {foodType}!");
            }

            var weightIncrease = quantity * WeightIncrease;
            this.Weight += weightIncrease;
            this.FoodEaten += quantity;
        }
    }
}
