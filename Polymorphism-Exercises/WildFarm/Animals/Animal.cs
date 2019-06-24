namespace WildFarm.Animals
{
    using WildFarm.Foods;

    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public abstract double WeightIncrease { get; }

        public abstract string ProduceSound();

        public abstract void EatFood(Food food);
    }
}
