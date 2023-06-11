using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.BL;

namespace BMS.DL
{
    class Bank_DL
    {
        public static void AddAccount(Account account)
        {
            Bank.accounts.Add(account);
        }

        public static void AddTransaction(Transaction transaction)
        {
            Bank.transactions.Add(transaction);
        }

        public static List<Transaction> GetTransactions(Account account)
        {
            return Bank.transactions.Where(t => t.acc == account).ToList();
        }

        public static void Deposit(Account account, double amount)
        {
            account.balance += amount;

            //Bank.transactions.Add(new Transaction
            //{
            //    TransactionId = Bank.transactions.Count + 1,
            //    Date = DateTime.Now,
            //    Amount = amount,
            //    TransactionType = "Deposit",
            //    Account = account
            //});
            int id = Bank.transactions.Count + 1;
            DateTime date = DateTime.Now;
            double Amount = amount;
            string transactionType = "Deposit";

            Account acc = account;

            Transaction t1 = new Transaction(id, date, Amount, transactionType, acc);
            Bank.transactions.Add(t1);
        }

        public static void Withdraw(Account account, double amount)
        {
            account.balance -= amount;
            //Bank.transactions.Add(new Transaction
            //{
            //    TransactionId = Bank.transactions.Count + 1,
            //    Date = DateTime.Now,
            //    Amount = amount,
            //    TransactionType = "Withdraw",
            //    Account = account
            //});

            int id = Bank.transactions.Count + 1;
            DateTime date = DateTime.Now;
            double Amount = amount;
            string transactionType = "WithDraw";

            Account acc = account;

            Transaction t1 = new Transaction(id, date, Amount, transactionType, acc);
            Bank.transactions.Add(t1);
        }
    }
}
