using Newtonsoft.Json;

namespace FakeTradeSupportService.Models.SimplifiedFrontierDeclaration
{
	public class SD_LookupResponse
	{
		[JsonProperty("sup_dec_number")]
		public string sup_dec_number { get; set; }

		[JsonProperty("sfd_number")]
		public string sfd_number { get; set; }
	}
}
