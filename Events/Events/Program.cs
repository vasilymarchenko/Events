using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(200);

            account.MinusEvent += new BankAccount.MinusHandler(ShowMinusMessage1);
            account.MinusEvent += new BankAccount.MinusHandler(ShowMinusMessage2);

            account.ZeroEvent += new BankAccount.ZeroHandler(ShowZeroMessage1);
            account.ZeroEvent += new BankAccount.ZeroHandler(ShowZeroMessage2);

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
