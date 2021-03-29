using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using System.Timers;

namespace FakeTradeSupportService
{
	public static class LongTaskSim
	{
		public async static Task<bool> WaitFive()
		{
			
			var timer = new Timer(3000);
			timer.Elapsed += OnTimedEvent;
			timer.AutoReset = true;
			timer.Enabled = true;

			timer.Stop();
			timer.Dispose();

			return true;
		}

		private static void OnTimedEvent(object sender, ElapsedEventArgs e)
		{
			Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
						  e.SignalTime);
		}
	}
}
