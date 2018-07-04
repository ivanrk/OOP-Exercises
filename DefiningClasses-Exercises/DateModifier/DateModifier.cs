namespace DateModifier
{
    using System;
    using System.Globalization;

    public class DateModifier
    {
        private string firstDate;
        private string secondDate;

        public DateModifier(string firstDate, string secondDate)
        {
            this.firstDate = firstDate;
            this.secondDate = secondDate;
        }
        
        public double CalculateDatesDifference()
        {
            var firstDate = DateTime.ParseExact(this.firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            var secondDate = DateTime.ParseExact(this.secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            var datesDifference = Math.Abs((secondDate - firstDate).TotalDays);
            return datesDifference;           
        }
    }
}
