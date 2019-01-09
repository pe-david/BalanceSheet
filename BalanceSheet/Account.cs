using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheet
{
    public class Account
    {
        static Account()
        {
            Console.WriteLine("Initial balance: $0.00");
        }

        public double Balance { get; private set; }

        public void Apply(Transaction transaction)
        {
            var temp = Balance + transaction.Amount;
            if (temp < 0)
            {
                throw new ArgumentOutOfRangeException("Balance cannot be below 0.");
            }

            Balance = temp;
            transaction.WriteTransaction();
        }
    }
}
