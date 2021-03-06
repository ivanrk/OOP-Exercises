﻿namespace WildFarm.Animals
{
    using System;
    using WildFarm.Foods;

    public class Dog : Mammal
    {
        private const double WeightIncreaseModifier = 0.40;

        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override double WeightIncrease => WeightIncreaseModifier;

        public override string ProduceSound()
        {
            return "Woof!";
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

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
