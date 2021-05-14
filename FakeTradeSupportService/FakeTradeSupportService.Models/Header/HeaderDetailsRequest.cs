using Newtonsoft.Json;

namespace FakeTradeSupportService.Models.Header
{
	public class HeaderDetailsRequest
	{
		[JsonProperty("declaration_number")]
		public string declaration_number { get; set; }

		[JsonProperty("fields")]
		public string fields { get; set; }
	}
}
