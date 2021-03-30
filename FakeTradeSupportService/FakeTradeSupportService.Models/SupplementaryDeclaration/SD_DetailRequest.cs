using Newtonsoft.Json;

namespace FakeTradeSupportService.Models.SupplementaryDeclaration
{
	public class SD_DetailRequest
	{
		[JsonProperty("supp_dec_number")]
		public string supp_dec_number { get; set; }


		[JsonProperty("fields")]
		public string fields { get; set; }
	}
}
