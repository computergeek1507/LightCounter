using System;

namespace LightCounter
{
	class LoggerEventArgs : EventArgs
	{
		public string Message { get; set; }
		public Level LogLevel { get; set; }
	}
}
