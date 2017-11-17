namespace Events
{
    class BankAccount
    {
        public delegate void MinusHandler(string msg);
        public delegate void ZeroHandler(string msg);

        public event MinusHandler MinusEvent;
        public event ZeroHandler ZeroEvent;
        
        public int Rest { get; private set; }

        public BankAccount(int startBalance)
        {
            Rest = startBalance;
        }

        public void GetMoney(int s)
        {
            if (Rest - s == 0)
            {
                if (ZeroEvent != null)
                {
                    ZeroEvent($"zero account: the rest = {Rest}; last operation was: -{s}");
                }
            }

            if (Rest - s < 0)
            {
                if (MinusEvent != null)
                {
                    MinusEvent($"minus account: the rest = {Rest}; try to get: {s}");
                }
                return;
            }

            Rest -= s;
        }
    }
}
