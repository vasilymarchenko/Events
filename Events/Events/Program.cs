using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(200);

            account.MinusEvent += (sender, eventArgs) =>
            {
                Console.WriteLine($"ShowMinusMessage1: {eventArgs.Message}, Rest={eventArgs.Rest}, OperationSum={eventArgs.OperationSum}");
            };
            account.MinusEvent += (sender, eventArgs) =>
            {
                Console.WriteLine($"ShowMinusMessage2: {eventArgs.Message}, Rest={eventArgs.Rest}, OperationSum={eventArgs.OperationSum}");
            };

            account.ZeroEvent += (sender, eventArgs) =>
            {
                Console.WriteLine($"ShowZeroMessage1: {eventArgs.Message}, Rest={eventArgs.Rest}, OperationSum={eventArgs.OperationSum}");
            };
            account.ZeroEvent += (sender, eventArgs) =>
            {
                Console.WriteLine($"ShowZeroMessage1: {eventArgs.Message}, Rest={eventArgs.Rest}, OperationSum={eventArgs.OperationSum}");
            };

            //account.GetMoney(200);
            //account.GetMoney(128);

            Type t = account.GetType();

            Type tt = typeof(BankAccount);

            Console.ReadLine();
        }
    }
}
