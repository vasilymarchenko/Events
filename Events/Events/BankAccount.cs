namespace Events
{
    class BankAccount
    {
        public delegate void MinusHandler(object sender, BankEventArgs bankEventArgs);
        public delegate void ZeroHandler(object sender, BankEventArgs bankEventArgs);

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
                    BankEventArgs args = new BankEventArgs("Zero account", Rest, s);
                    ZeroEvent(this, args);
                }
            }

            if (Rest - s < 0)
            {
                if (MinusEvent != null)
                {
                    BankEventArgs args = new BankEventArgs("Minus account", Rest, s);
                    MinusEvent(this, args);
                }
                return;
            }

            Rest -= s;
        }
    }
}
