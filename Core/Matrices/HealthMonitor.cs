using System;
using AutomationArchitechtLab.Core.Logging;

namespace AutomationArchitechtLab.Core.Matrices
{
	public class HealthMonitor
	{
		public static void Track(string operation, timespan duration)
		{
			Logger.Info($"{operation} took {duration.TotalMillisecond} ms");
		}
	}
	
}