using System;

namespace AutomationArchitechtLab.Core.Logger
{
	public class Logger{
		
		public static void Info(string msg) => Console.WriteLine($"{DateTime.Now} INFO: {msg}");
		public static void Error(string msg) => Console.WriteLine($"{DateTime.Now} Error: {msg}");
	}	
}