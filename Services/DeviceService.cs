using AutomationArchitechtLab.Core.Http;
using AutomationArchitechtLab.Contracts.Requests;
using AutomationArchitechtLab.Core.Execution;
using System.Diagnostics;
using AutomationArchitechtLab.Core.Matrics;

namespace AutomationArchitechtLab.Contracts.Services
{	
	public class DeviceService
	{
		public void CreateDevice(CreateDeviceRequest request)
		{
			ExecutionGuard(()=>
			{
			var watch = Stopwatch.StartNew();
			ApiCLient.Post("api/createdevice",request);
			watch.Stop();
			HealthMonitorTrack("Create Device", watch.Elapsed);
			}			
			);
		}
	}
}