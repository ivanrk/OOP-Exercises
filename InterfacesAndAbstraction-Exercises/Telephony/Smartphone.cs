namespace Telephony
{
    using System.Linq;

    public class Smartphone : ICallable, IBrowseable
    {
        public string BrowseWeb(string url)
        {
            if (url.Any(char.IsDigit))
            {
                return "Invalid URL!";
            }
            return $"Browsing: {url}!";
        }

        public string CallPhone(string phoneNumber)
        {
            if (!phoneNumber.All(char.IsDigit))
            {
                return "Invalid number!";
            }
            return $"Calling... {phoneNumber}";
        }
    }
}
