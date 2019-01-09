using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheet
{
    public class DebitTransaction : Transaction
    {
        public DebitTransaction()
        {
        }

        public override void Apply(double amount)
        {
            Amount = amount;
        }
    }
}
