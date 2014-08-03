using System.Collections.Generic;

namespace Katas.BankTransfer.Code
{
    public class Account
    {
        private readonly int _accountNumber;

        public Account(int accountNumber)
        {
            _accountNumber = accountNumber;
            _transactions = new List<Transaction>();
        }

        private double _balance;

        public int AccountNumber
        {
            get { return _accountNumber; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        private readonly List<Transaction> _transactions;
        public List<Transaction> Transactions
        {
            get { return _transactions; }
        }

        public void Transfer(double amount, Account payee)
        {
            _balance -= amount;
            Transactions.Add(new Transaction("Debit", payee, amount));
            payee.Balance += amount;
            payee.Transactions.Add(new Transaction("Credit", this, amount));
        }

        public List<Transaction> GetTransactionsWhere(string type, Account account)
        {
            List<Transaction> transactions = new List<Transaction>();
            foreach (Transaction transaction in Transactions)
            {
                if (transaction.Type == type && transaction.OtherAccount == account)
                {
                    transactions.Add(transaction);
                }
            }
            return transactions;
        }

        public override bool Equals(object obj)
        {
            return ((Account)obj).AccountNumber == _accountNumber;
        }
    }
}