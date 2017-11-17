using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(200);

            account.RegisterMinusHandler(ShowMinusMessage1);
            account.RegisterMinusHandler(ShowMinusMessage2);

            account.RegisterZeroHandler(ShowZeroMessage1);
            account.RegisterZeroHandler(ShowZeroMessage2);

            account.GetMoney(200);
            account.GetMoney(128);

            Console.ReadLine();
        }

        public static void ShowMinusMessage1(string text)
        {
            Console.WriteLine($"ShowMinusMessage1: {text}");
        }

        public static void ShowMinusMessage2(string text)
        {
            Console.WriteLine($"ShowMinusMessage2: {text}");
        }

        public static void ShowZeroMessage1(string text)
        {
            Console.WriteLine($"ShowMinusMessage1: {text}");
        }

        public static void ShowZeroMessage2(string text)
        {
            Console.WriteLine($"ShowMinusMessage2: {text}");
        }
    }
}
