using System.Net.Http;
using System.Text;
using System.Text.Json;
using AutomationArchitechtLab.Core.Context;

namespace AutomationArchitechtLab.Core.Http
{
	public static class ApiClient
	{
		static HttpClient client = new HttpClient();
		
		public static HttpResponseMessage Post(string url, object body)
		{
			var inputBody = JsonSerializer.Serialize(body);
			client.DefaultRequestHeader.Clear();
			client.DefaultRequestHeader.Add("Authorization",$"Bearer {TestContext.Token}");
		}
	}
	
}

