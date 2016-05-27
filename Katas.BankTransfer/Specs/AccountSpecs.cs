using Katas.BankTransfer.Code;
using NUnit.Framework;

namespace Katas.BankTransfer.Specs
{
    [TestFixture]
    public class AccountSpecs
    {
        private Account payer;
        private Account payee;

        [SetUp]
        public virtual void SetUp()
        {
            payee = new Account(1);
            payer = new Account(2);
            payer.Balance = 200;
        }

        [Test]
        public void Transfer_PayerBalanceShouldBeReducedByAmountOfTransaction()
        {
            payer.Transfer(50, payee);
            Assert.AreEqual(150, payer.Balance);
        }

        [Test]
        public void Transfer_PayeeBalanceShouldBeIncreasedByAmountOfTransaction()
        {
            payer.Transfer(50, payee);
            Assert.AreEqual(50, payee.Balance);
        }

        [Test]
        public void Transfer_TransactionShouldBeRecordedAsDebitInPayerTransactionHistory()
        {
            payer.Transfer(50, payee);

            Assert.AreEqual(1, payer.Transactions.Count);
            Transaction transaction = payer.Transactions[0];
            Assert.AreEqual("Debit", transaction.Type);
            Assert.AreEqual(payee, transaction.OtherAccount);
            Assert.AreEqual(50, transaction.Amount);
        }

        [Test]
        public void Transfer_TransactionShouldBeRecordedAsCreditInPayeeTransactionHistory()
        {
            payer.Transfer(50, payee);

            Assert.AreEqual(1, payee.Transactions.Count);
            Transaction transaction = payee.Transactions[0];
            Assert.AreEqual("Credit", transaction.Type);
            Assert.AreEqual(payer, transaction.OtherAccount);
            Assert.AreEqual(50, transaction.Amount);
        }

        [Test]
        public void TransactionHistory_ShouldBeAbleToQueryToOrFromAccount()
        {
            payer.Transactions.Add(new Transaction("Credit", payee, 100));
            payer.Transactions.Add(new Transaction("Debit", payee, 100));
            payer.Transactions.Add(new Transaction("Credit", payee, 100));
            payer.Transactions.Add(new Transaction("Debit", new Account(3), 100));

            var payerResults = payer.GetTransactionsWhere("Debit", payee);
            Assert.AreEqual(1, payerResults.Count);
        }
    }
}
