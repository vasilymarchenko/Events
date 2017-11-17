using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(200);

            account.MinusEvent += ShowMinusMessage1;
            account.MinusEvent += ShowMinusMessage2;
            //account.MinusEvent += AccountOnMinusEvent;

            account.ZeroEvent += ShowZeroMessage1;
            account.ZeroEvent += ShowZeroMessage2;

            account.GetMoney(200);
            account.GetMoney(128);

            Console.ReadLine();
        }

        //private static void AccountOnMinusEvent(string msg)
        //{
        //    throw new NotImplementedException();
        //}

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
