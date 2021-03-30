using Newtonsoft.Json;

namespace FakeTradeSupportService.Models.SimplifiedFrontierDeclaration
{
	public class SFD_DetailRequest
	{
		[JsonProperty("sfd_number")]
		public string sfd_number { get; set; }


		[JsonProperty("fields")]
		public string fields { get; set; }
	}
}
