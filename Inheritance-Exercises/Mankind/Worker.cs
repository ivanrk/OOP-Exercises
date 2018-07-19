namespace Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private const decimal MIN_WEEK_SALARY = 10;
        private const int MIN_WORK_HOURS = 1;
        private const int MAX_WORK_HOURS = 12;

        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHours = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            private set
            {
                if (value <= MIN_WEEK_SALARY)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(this.weekSalary)}");
                }
                this.weekSalary = value;
            }
        }

        public decimal WorkingHours
        {
            get { return this.workHoursPerDay; }
            private set
            {
                if (value < MIN_WORK_HOURS || value > MAX_WORK_HOURS)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(this.workHoursPerDay)}");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal CalculateSalaryPerHour()
        {
            var salaryPerDay = this.WeekSalary / 5.0m;
            return salaryPerDay / this.WorkingHours;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
            sb.AppendLine($"Hours per day: {this.WorkingHours:f2}");
            sb.Append($"Salary per hour: {this.CalculateSalaryPerHour():f2}");
            return sb.ToString();
        }
    }
}
