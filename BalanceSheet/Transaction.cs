using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheet
{
    public abstract class Transaction
    {
        protected Transaction()
        {
            Account = new Account();
        }

        public double Amount { get; protected set; }

        protected Account Account { get; private set; }

        public abstract void Apply(double amount);

        public void WriteTransaction()
        {
            Console.WriteLine("transaction occured...");
        }
    }
}
