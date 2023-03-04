namespace MyNamespace
{
    class CheckingAcct : Account
    {
        const decimal WITHDRAWAL_FEE = 35.0m;
        public CheckingAcct(string fn, string ln, decimal bal) : base(fn, ln, bal)
        { }


        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            if (amount > base.Balance)
            {
                base.Withdraw(WITHDRAWAL_FEE);
            }
        }

    }
}