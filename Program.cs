namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            CheckingAcct checking = new CheckingAcct("John", "Doe", 2500.0m);

            SavingsAcct saving = new SavingsAcct("Jane", "Doe", 0.025m, 1000.0m);

            //check balances
            //Expected output should be 2500 and 1000
            Console.WriteLine($"Checking balance is {checking.Balance:c2}");
            Console.WriteLine($"Savings balance is {saving.Balance:c2}");

            // Print the acc owner information. Expected output
            // "Checking owner: John Doe"
            // "Savings owner: Jane Doe"
            Console.WriteLine($"Checking owner: {checking.AccountOwner}");
            Console.WriteLine($"Savings owner: {saving.AccountOwner}");

            // Deposit some money
            checking.Deposit(200.0m);
            saving.Deposit(150.0m);

            //check balances
            //Expected output should be 2700 and 1150
            Console.WriteLine($"Checking balance is {checking.Balance:c2}");
            Console.WriteLine($"Savings balance is {saving.Balance:c2}");

            // Withdraw some money
            checking.Withdraw(50.0m);
            saving.Withdraw(125.0m);

            //check balances
            //Expected output should be 2650 and 1025
            Console.WriteLine($"Checking balance is {checking.Balance:c2}");
            Console.WriteLine($"Savings balance is {saving.Balance:c2}");

            // Apply saving interest
            saving.ApplyInterest();

            // savings balance should now be 1050.63
            Console.WriteLine($"Savings balance is {saving.Balance:c2}");

            // More than 3 savings withdrawals should result in 2.00 charge
            saving.Withdraw(10.0m);
            saving.Withdraw(20.0m);
            saving.Withdraw(30.0m);

            // savings balance should now be 988.63
            Console.WriteLine($"Savings balance is {saving.Balance:c2}");

            // try to overdraw savings - should be denied and print message
            saving.Withdraw(2000.0m);

            // try to overdraw checking - should result in extra charge (35)
            checking.Withdraw(3000.0m);


            //check balances
            //Expected output should be -385 and 988.63
            Console.WriteLine($"Checking balance is {checking.Balance:c2}");
            Console.WriteLine($"Savings balance is {saving.Balance:c2}");

        }
    }
}