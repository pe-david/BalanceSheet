using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheet
{
    public abstract class Transaction
    {
        protected string TransactionType { get; set; }

        public double Amount { get; protected set; }

        public abstract void Apply(double amount, Account account);

        public void WriteTransaction()
        {
            Console.WriteLine($"{TransactionType} transaction: ${Amount:0.00}");
        }
    }
}
