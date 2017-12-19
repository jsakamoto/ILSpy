using System;
using System.Diagnostics;
using System.IO;

namespace ILSpy.ClickOnceBootStrap
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			var baseDir = AppDomain.CurrentDomain.BaseDirectory;
			var path = Path.Combine(baseDir, ".bin", "ILSpy.exe");
			using (var process = Process.Start(path, string.Join(" ", args))) {
				process.WaitForExit();
			}
		}
	}
}
