namespace Google
{
    using System.Text;

    public class Car
    {
        private string model;
        private int speed;

        public Car(string model, int speed)
        {
            this.model = model;
            this.speed = speed;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Car:");
            if (this.model != null)
            {
                sb.Append($"{this.model} {this.speed}");
            }
            return sb.ToString();
        }
    }
}
