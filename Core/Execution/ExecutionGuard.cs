using AutomationArchitechtLab.Core.Logging;
using AutomationArchitechtLab.Core.Retry;

namespace AutomationArchitechtLab.Core.Execution
{
	public class ExecutionGuard
	{
		public static void Run(System.Action action, int retry = 2)
		{
			Logger.Info("Execution Started");
			RetryEngine.Execute(action,retry);
			Logger.Info("Execution Completed");
		}		
	}
	
	
}