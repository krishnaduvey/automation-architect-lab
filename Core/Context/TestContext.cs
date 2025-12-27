
//StateManager
namespace AutomationArchitechLab.Core.Context
{
	
	public class TestContext{		
		//public static string Environment{ get; set;}
		//public static string token {get; set;}
		//public static string CorrelationId {get; set;}
		// To make parallal safe context
		public static AsyncLocal<string> Environment = new();
		public static AsyncLocal<string> token = new();
		public static AsyncLocal<string> CorrelationId = new();
	}
}

