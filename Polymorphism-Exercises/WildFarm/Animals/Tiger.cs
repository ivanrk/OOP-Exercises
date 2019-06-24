namespace WildFarm.Animals
{
    using System;
    using WildFarm.Foods;

    public class Tiger : Feline
    {
        private const double WeightIncreaseModifier = 1;

        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightIncrease => WeightIncreaseModifier;

        public override string ProduceSound()
        {
            return "ROAR!!!";
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
