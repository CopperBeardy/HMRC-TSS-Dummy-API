using Newtonsoft.Json;

namespace FakeTradeSupportService.Models.SimplifiedFrontierDeclaration
{
	public class SFD_LookupResponse
	{
		[JsonProperty("consignment_number")]
		public string consignment_number { get; set; }

		[JsonProperty("sfd_number")]
		public string sfd_number { get; set; }
	}
}
