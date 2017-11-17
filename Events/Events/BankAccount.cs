namespace Events
{
    class BankAccount
    {
        public delegate void MinusHandler(string msg);

        private MinusHandler _handlers;

        public void RegisterHandler(MinusHandler methodToCall)
        {
            _handlers += methodToCall;
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
                if (_handlers != null)
                {
                    _handlers($"minus account: the rest = {Rest}; try to get: {s}");
                }
                return;
            }

            Rest = -s;
        }
    }
}
