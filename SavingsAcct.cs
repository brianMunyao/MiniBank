namespace MyNamespace
{
    class SavingsAcct : Account
    {
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
                if (withdrawCount == 3)
                {
                    Console.WriteLine("More than 3 withdrwawals - extra charge");
                    base.Withdraw(2.0m);
                }
            }
        }

        public void ApplyInterest()
        {
            decimal added = _interest * base.Balance;
            base.Deposit(added);
            withdrawCount = 0;
        }
    }
}