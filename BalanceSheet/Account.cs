using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheet
{
    public class Account
    {
        public double Balance { get; private set; }

        public void Apply(Transaction transaction)
        {
            Balance += transaction.Amount;
            transaction.WriteTransaction();
        }
    }
}
