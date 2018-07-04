namespace Google
{
    using System.Text;

    public class Company
    {
        private string name;
        private string department;
        private decimal salary;

        public Company(string name, string department, decimal salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Company:");
            sb.Append($"{this.name} {this.department} {this.salary:f2}");
            return sb.ToString();
        }
    }
}
