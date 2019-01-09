using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheet
{
    public class AccountSvc
    {
        private Account account = new Account();

        public AccountSvc()
        {
        }

        public double GetBalance()
        {
            return account.Balance;
        }

        public void ApplyCredit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be less than 0.");
            }

            account.ApplyCredit(amount);
        }

        public void ApplyDebit(double amount)
        {
            if (amount >= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be greater than or equal to 0.");
            }

            account.ApplyDebit(amount);
        }
    }
}
