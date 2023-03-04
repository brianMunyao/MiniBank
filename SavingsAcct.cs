namespace MyNamespace
{
    class SavingsAcct : Account
    {
        const int WITHDRAWAL_LIMIT = 3;
        const decimal WITHDRAWAL_FEE = 2.0m;
        decimal _interest;
        int withdrawCount = 0;

        public SavingsAcct(string fn, string ln, decimal interest, decimal bal) : base(fn, ln, bal)
        {
            _interest = interest;
        }


        public override void Withdraw(decimal amount)
        {
            if (amount > base.Balance)
            {
                Console.WriteLine("Attempt to overdraw savings - denied");
            }
            else
            {
                base.Withdraw(amount);
                withdrawCount++;
                if (withdrawCount > WITHDRAWAL_LIMIT)
                {
                    Console.WriteLine($"More than {WITHDRAWAL_LIMIT} withdrwawals - extra charge");
                    base.Withdraw(WITHDRAWAL_FEE);
                }
            }
        }

        public void ApplyInterest()
        {
            decimal added = _interest * base.Balance;
            base.Deposit(added);
        }
    }
}