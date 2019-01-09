using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheet
{
    public abstract class Transaction
    {
        static Transaction()
        {
            Account = new Account();
        }

        protected string TransactionType { get; set; }

        public double Amount { get; protected set; }

        protected static Account Account { get; private set; }

        public abstract void Apply(double amount);

        public void WriteTransaction()
        {
            Console.WriteLine($"{TransactionType} transaction: ${Amount:0.00} Balance: {Account.Balance}");
        }
    }
}
