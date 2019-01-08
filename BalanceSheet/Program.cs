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
			double total = 0.0;
			var list = new List<double>() { 30.0, -30.0, 40.0, 50.0, -10.0, 20.0 }
			.ToObservable();

			Console.WriteLine("Starting balance: $0.00");
			list
				.SubscribeOn(NewThreadScheduler.Default)
				.Subscribe(
				val =>
				{
					System.Threading.Thread.Sleep(2000);
					total += val;
					string cred = val < 0 ? "debit" : "credit";
					string msg = $"${val:0.00} {cred:0.00} Balance = ${total:0.00}";
					Console.WriteLine(msg);
				});

			Console.ReadKey();
		}
	}
}
