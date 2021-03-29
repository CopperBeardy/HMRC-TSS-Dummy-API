using Newtonsoft.Json;

namespace FakeTradeSupportService.Models
{

	public class AdditionalInformation
	{
		[JsonProperty("op_type")]
		public string op_type { get; set; }

		[JsonProperty("additional_info_code")]
		public string additional_info_code { get; set; }

		[JsonProperty("additional_info_description")]
		public string additional_info_description { get; set; }
	}

}
