namespace Events
{
    class BankAccount
    {
        public delegate void MinusHandler(string msg);
        public delegate void ZeroHandler(string msg);

        private MinusHandler _minusHandler;
        private ZeroHandler _zeroHandler;

        public void RegisterMinusHandler(MinusHandler methodToCall)
        {
            _minusHandler += methodToCall;
        }

        public void RegisterZeroHandler(ZeroHandler methodToCall)
        {
            _zeroHandler += methodToCall;
        }
        public int Rest { get; private set; }

        public BankAccount(int startBalance)
        {
            Rest = startBalance;
        }

        public void GetMoney(int s)
        {
            if (Rest - s == 0)
            {
                if (_zeroHandler != null)
                {
                    _zeroHandler($"zero account: the rest = {Rest}; last operation was: -{s}");
                }
            }

            if (Rest - s < 0)
            {
                if (_minusHandler != null)
                {
                    _minusHandler($"minus account: the rest = {Rest}; try to get: {s}");
                }
                return;
            }

            Rest -= s;
        }
    }
}
