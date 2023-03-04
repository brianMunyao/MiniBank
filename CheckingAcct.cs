namespace MyNamespace
{
    class CheckingAcct : Account
    {

        public CheckingAcct(string fn, string ln, decimal bal) : base(fn, ln, bal)
        { }


        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            if (amount > base.Balance)
            {
                base.Withdraw(35.0m);
            }
        }

    }
}