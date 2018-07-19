namespace Mankind
{
    using System;
    using System.Text;

    public class Student : Human
    {
        private const int F_NUMBER_MIN_LENGTH = 5;
        private const int F_NUMBER_MAX_LENGTH = 10;

        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            private set
            {
                if (value.Length < F_NUMBER_MIN_LENGTH || value.Length > F_NUMBER_MAX_LENGTH)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                else if (!ConsistsOfDigitsAndLetters(value))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        private bool ConsistsOfDigitsAndLetters(string value)
        {
            var hasOnlyDigitsAndLetters = true;
            foreach (var ch in value)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    hasOnlyDigitsAndLetters = false;
                    break;
                }
            }
            return hasOnlyDigitsAndLetters;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($"Faculty number: {this.FacultyNumber}");
            return sb.ToString();
        }
    }
}
