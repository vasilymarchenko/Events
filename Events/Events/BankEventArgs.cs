using System;

namespace Events
{
    public class BankEventArgs: EventArgs
    {
        public readonly string Message;
        public readonly int Rest;
        public readonly int OperationSum;

        public BankEventArgs(string message, int rest, int operationSum)
        {
            Message = message;
            Rest = rest;
            OperationSum = operationSum;
        }
    }
}
