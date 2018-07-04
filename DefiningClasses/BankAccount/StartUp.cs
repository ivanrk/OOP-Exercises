namespace BankAccount
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var command = Console.ReadLine().Split(' ');

            var bankAccounts = new Dictionary<int, BankAccount>();

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Create":
                        Create(command, bankAccounts);
                        break;
                    case "Deposit":
                        Deposit(command, bankAccounts);
                        break;
                    case "Withdraw":
                        Withdraw(command, bankAccounts);
                        break;
                    case "Print":
                        Print(command, bankAccounts);
                        break;
                    default:
                        Console.WriteLine("Enter a valid command");
                        break;
                }

                command = Console.ReadLine().Split(' ');
            }
        }

        private static void Print(string[] command, Dictionary<int, BankAccount> bankAccounts)
        {
            var id = int.Parse(command[1]);

            if (bankAccounts.ContainsKey(id))
            {
                Console.WriteLine(bankAccounts[id]);
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Withdraw(string[] command, Dictionary<int, BankAccount> bankAccounts)
        {
            var id = int.Parse(command[1]);
            var amount = decimal.Parse(command[2]);

            if (!bankAccounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }  
            else if (bankAccounts[id].Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                bankAccounts[id].Balance -= amount;
            }
        }

        private static void Deposit(string[] command, Dictionary<int, BankAccount> bankAccounts)
        {
            var id = int.Parse(command[1]);
            var amount = decimal.Parse(command[2]);

            if (bankAccounts.ContainsKey(id))
            {
                bankAccounts[id].Balance += amount;
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Create(string[] command, Dictionary<int, BankAccount> bankAccounts)
        {
            var id = int.Parse(command[1]);

            if (bankAccounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount();
                acc.Id = id;
                bankAccounts.Add(id, acc);
            }
        }
    }
}