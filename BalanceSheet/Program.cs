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

            var svc = new AccountSvc();

            while (true)
            {
                var line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    break;
                }

                if (double.TryParse(line, out var val))
                {
                    try
                    {
                        if (val < 0)
                        {
                            svc.ApplyDebit(val);
                        }
                        else
                        {
                            svc.ApplyCredit(val);
                        }
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message.Split('\n')[0]);
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
