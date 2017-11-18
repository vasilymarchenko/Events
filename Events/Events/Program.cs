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

            account.ZeroEvent += ShowZeroMessage1;
            account.ZeroEvent += ShowZeroMessage2;

            account.GetMoney(200);
            account.GetMoney(128);

            Console.ReadLine();
        }

        public static void ShowMinusMessage1(object sender, BankEventArgs args)
        {
            Console.WriteLine($"ShowMinusMessage1: {args.Message}, Rest={args.Rest}, OperationSum={args.OperationSum}");
        }

        public static void ShowMinusMessage2(object sender, BankEventArgs args)
        {
            Console.WriteLine($"ShowMinusMessage1: {args.Message}, Rest={args.Rest}, OperationSum={args.OperationSum}");
        }

        public static void ShowZeroMessage1(object sender, BankEventArgs args)
        {
            Console.WriteLine($"ShowZeroMessage1: {args.Message}, Rest={args.Rest}, OperationSum={args.OperationSum}");
        }

        public static void ShowZeroMessage2(object sender, BankEventArgs args)
        {
            Console.WriteLine($"ShowZeroMessage1: {args.Message}, Rest={args.Rest}, OperationSum={args.OperationSum}");
        }
    }
}
