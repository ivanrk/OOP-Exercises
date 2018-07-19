namespace CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }

        public string Model { get; }

        public int Power { get; }

        public string Displacement { get; set; }

        public string Efficiency { get; set; }
    }
}
