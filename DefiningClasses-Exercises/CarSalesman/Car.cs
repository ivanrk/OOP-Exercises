namespace CarSalesman
{
    public class Car
    {
        public string Model { get; }

        public Engine Engine { get; }

        public string Weight { get; set; }

        public string Color { get; set; }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }
    }
}
