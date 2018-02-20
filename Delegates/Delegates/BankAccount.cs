using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class BankAccount
    {
        public delegate void MinusHandler(string msg);

        private MinusHandler handlers;


        public void RegisterHandler(MinusHandler methodToCall)
        {
            //handlers = methodToCall;
            handlers += methodToCall;
        }
        public int Rest { get; private set; }

        public BankAccount(int startBalance)
        {
            Rest = startBalance;
        }

        public void GetMoney(int s)
        {
            if (Rest - s < 0)
            {
                if (handlers != null)
                {
                    handlers("minus account");
                }
            }

            Rest = -s;
        }
    }

    class BankAccount2
    {
        public delegate void AccountHandler(string msg);

        public event AccountHandler ZeroRest;
        public event AccountHandler MinusRest;


        public int Rest { get; private set; }

        public BankAccount2(int startBalance)
        {
            Rest = startBalance;
        }

        public void GetMoney(int s)
        {
            if (Rest - s == 0)
            {
                if (ZeroRest != null)
                {
                    ZeroRest("zero rest");
                }
            }

            if (Rest - s < 0)
            {
                if (MinusRest != null)
                {
                    MinusRest("minus rest");
                }
            }

            Rest = -s;
        }

    }
}
