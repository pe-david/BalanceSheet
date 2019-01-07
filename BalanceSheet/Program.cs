using System;
using System.Collections.Generic;
using System.Linq;
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

			list.Delay(TimeSpan.FromSeconds(2))
				.Subscribe(
				val =>
				{
					total += val;
					string cred = val < 0 ? "debit" : "credit";
					string msg = $"${val} {cred} Balance = ${total}";
					Console.WriteLine(msg);
				});

			Console.ReadKey();
		}
	}
}
