using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSheet
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Hit return on an empty line to cancel...");
            Console.WriteLine("Enter a value. Negative values are debits, positive are credits.");

            Account account = new Account();

            while (true)
            {
                var line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    break;
                }

                double val;
                Transaction trans = null;
                if (double.TryParse(line, out val))
                {
                    if (val < 0)
                    {
                        trans = new DebitTransaction();
                    }
                    else
                    {
                        trans = new CreditTransaction();
                    }

                    try
                    {
                        trans.Amount = val;
                        account.Apply(trans);
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine($"Error: {e.ParamName}");
                    }
                }
                else
                {
                    Console.WriteLine("Unable to process transaction.");
                }
            }
        }
	}
}
