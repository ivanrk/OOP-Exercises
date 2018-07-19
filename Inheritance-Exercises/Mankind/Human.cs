namespace Mankind
{
    using System;
    using System.Text;

    public class Human
    {
        private const int F_NAME_MIN_LENGTH = 4;
        private const int L_NAME_MIN_LENGTH = 3;

        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            protected set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {nameof(this.firstName)}");
                }
                else if (value.Length < F_NAME_MIN_LENGTH)
                {
                    throw new ArgumentException($"Expected length at least {F_NAME_MIN_LENGTH} symbols! Argument: {nameof(this.firstName)}");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            protected set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {nameof(this.lastName)}");
                }
                else if (value.Length < L_NAME_MIN_LENGTH)
                {
                    throw new ArgumentException($"Expected length at least {L_NAME_MIN_LENGTH} symbols! Argument: {nameof(this.lastName)}");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");
            return sb.ToString();
        }
    }
}
