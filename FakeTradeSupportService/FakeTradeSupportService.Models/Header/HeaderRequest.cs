using Newtonsoft.Json;

namespace FakeTradeSupportService.Models.Header
{
	public class HeaderRequest : Header
	{
		[JsonProperty("op_type")]
		public string op_type { get; set; } = "cancel";

	
	}
}
