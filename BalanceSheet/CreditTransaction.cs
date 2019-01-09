﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheet
{
    public class CreditTransaction : Transaction
    {
        public CreditTransaction()
        {
        }

        public override void Apply(double amount)
        {
            Amount = amount;
        }
    }
}