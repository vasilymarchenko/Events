using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(200);
            account.RegisterHandler(ShowMessage1);
            account.RegisterHandler(ShowMessage2);

            account.GetMoney(250);

            Console.ReadLine();
        }

        public static void ShowMessage1(string text)
        {
            Console.WriteLine($"ShowMessage1: {text}");
        }

        public static void ShowMessage2(string text)
        {
            Console.WriteLine($"ShowMessage2: {text}");
        }
    }
}
