using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Enters the 'inspect' mode. In this mode, elements that user is hovering over are highlighted. Backend then generates 'inspectNodeRequested' event upon element selection.
	/// </summary>
	[Command(ProtocolName.DOM.SetInspectModeEnabled)]
	[SupportedBy("Chrome")]
	public class SetInspectModeEnabledCommand
	{
		/// <summary>
		/// Gets or sets True to enable inspection mode, false to disable it.
		/// </summary>
		public bool Enabled { get; set; }
		/// <summary>
		/// Gets or sets True to enable inspection mode for user agent shadow DOM.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? InspectUAShadowDOM { get; set; }
		/// <summary>
		/// Gets or sets A descriptor for the highlight appearance of hovered-over nodes. May be omitted if <code>enabled == false</code>.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public HighlightConfig HighlightConfig { get; set; }
	}
}
