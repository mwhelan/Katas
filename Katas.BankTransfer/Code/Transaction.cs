namespace Katas.BankTransfer.Code
{
    public class Transaction
    {
        public Transaction(string type, Account otherAccount, double amount)
        {
            Type = type;
            OtherAccount = otherAccount;
            Amount = amount;
        }

        public string Type { get; private set; }

        public Account OtherAccount { get; private set; }

        public double Amount { get; private set; }
    }
}