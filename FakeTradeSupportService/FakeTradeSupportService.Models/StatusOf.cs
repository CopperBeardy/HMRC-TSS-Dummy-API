using Newtonsoft.Json;

namespace FakeTradeSupportService.Models
{
	public class StatusOf
	{
		[JsonProperty("status")]
		public string status { get; set; }
	}
}
