namespace Telephony
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split();
            var urlAddresses = Console.ReadLine().Split();

            ICallable smartphone = new Smartphone();
            foreach (var phNumber in phoneNumbers)
            {
                Console.WriteLine(smartphone.CallPhone(phNumber));
            }

            IBrowseable newSmartphone = new Smartphone();
            foreach (var url in urlAddresses)
            {
                Console.WriteLine(newSmartphone.BrowseWeb(url));
            }
        }
    }
}
