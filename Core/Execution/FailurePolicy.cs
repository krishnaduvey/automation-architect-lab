using System;

namespace AutomationSrchitechtLab.Core.Execution
{
	public static class FailurePolicy
	{
		public static book IsRetriable(Execption ex)
		{
			return ex.Message.Contains("timeout") || ex.Message.Contains("502");
		}
	}	
}