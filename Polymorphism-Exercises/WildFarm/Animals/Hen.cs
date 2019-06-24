namespace WildFarm.Animals
{
    using WildFarm.Foods;

    public class Hen : Bird
    {
        private const double WeightIncreaseModifier = 0.35;

        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override double WeightIncrease => WeightIncreaseModifier;

        public override string ProduceSound()
        {
            return "Cluck";
        }

        public override void EatFood(Food food)
        {
            var quantity = food.Quantity;

            var weightIncrease = quantity * WeightIncrease;
            this.Weight += weightIncrease;
            this.FoodEaten += quantity;
        }
    }
}
