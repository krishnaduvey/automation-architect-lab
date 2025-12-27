using System;

//Centralize logging
namespace AutomationArchitechtLab.Core.Retry
{
	public class RetryEngine{
		public static void Execute(Action action, int times)
		{
		for(int i=1;i<=times;i++)
		{
			try 
			{
				action();
				return;
			}
			catch(Exception ex) when (i < times && FailurePolicy.IsRetriable(ex))			
			
			// {
				// when(i < times)
				// {
					// Thread.Sleep(1000);
				// }
			// }			
		}
	}
}