namespace MyNamespace
{
    class Account
    {
        string _firstName;
        string _lastName;
        decimal _balance;

        public Account(string fn, string ln, decimal bal)
        {
            _firstName = fn;
            _lastName = ln;
            _balance = bal;
        }

        public string AccountOwner
        {
            get => _firstName + " " + _lastName;
        }
        public decimal Balance
        {
            get => _balance;
        }

        public virtual void Withdraw(decimal amount)
        {
            _balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }
    }
}