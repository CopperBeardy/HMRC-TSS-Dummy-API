using Newtonsoft.Json;

namespace FakeTradeSupportService.Models
{
	public class StandardResponse
	{
		[JsonProperty("status")]
		public string status { get; set; }

		[JsonProperty("process_message")]
		public string process_message { get; set; }

		[JsonProperty("reference")]
		public string reference { get; set; }



	}
}
