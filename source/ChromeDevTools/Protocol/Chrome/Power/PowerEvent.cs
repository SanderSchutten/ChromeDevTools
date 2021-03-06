using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Power
{
	/// <summary>
	/// PowerEvent item
	/// </summary>
	[SupportedBy("Chrome")]
	public class PowerEvent
	{
		/// <summary>
		/// Gets or sets Power Event Type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Power Event Time, in milliseconds.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Power Event Value.
		/// </summary>
		public double Value { get; set; }
	}
}
