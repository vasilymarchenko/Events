using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            BinOp AddOperation = new BinOp(SimpleDelegate.Add);

            BinOp SubstrOperation = new BinOp(SimpleDelegate.Substract);

            var x = AddOperation(1, 2);
            var y = SubstrOperation(3, 2);

            Console.WriteLine($"x={x}, y={y}");
            

            var invokes = AddOperation.GetInvocationList();
            Console.WriteLine(invokes[0].Method);
            Console.WriteLine(invokes[0].Target);

            SimpleDelegate simpleDelegate = new SimpleDelegate();
            BinOp Multi = new BinOp(simpleDelegate.Multi);

            invokes = Multi.GetInvocationList();
            Console.WriteLine(invokes[0].Method);
            Console.WriteLine(invokes[0].Target);
            */

            /*
            BankAccount acc = new BankAccount(100);
            acc.RegisterHandler(MinusEvent);
            acc.RegisterHandler(MinusEvent2);
            acc.GetMoney(150);
            */

            /*
            MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(GenericDelegate.StringTarget);
            MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(GenericDelegate.IntTarget);

            strTarget("bla-bla");
            intTarget(100500);
            */

            /*
            Action<int, string> targetAction = new Action<int, string>(ActionFunc.DoSmth);
            targetAction(100, "bla-bla");
            */

            BankAccount2 account2 = new BankAccount2(100);
            account2.MinusRest += MinusEvent;
            account2.ZeroRest += ZeroEvent;
            account2.GetMoney(100);
            account2.GetMoney(1);

            Console.ReadLine();
        }

        public static void MinusEvent(string msg)
        {
            Console.WriteLine("Alarm! Minus account!");
        }

        public static void MinusEvent2(string msg)
        {
            Console.WriteLine("Alarm2! Minus account!");
        }

        public static void ZeroEvent(string msg)
        {
            Console.WriteLine("Alarm2! Zero account!");
        }
    }
}
