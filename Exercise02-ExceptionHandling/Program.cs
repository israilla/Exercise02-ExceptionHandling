using System;
using Exercise02_ExceptionHandling.Entities;
using Exercise02_ExceptionHandling.Entities.Exceptions;

namespace Exercise02_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine();

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            try
            {
                account.Withdraw(amount);
                Console.WriteLine("New Balance: " + account);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}

