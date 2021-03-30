using Newtonsoft.Json;

namespace FakeTradeSupportService.Models
{

	public class HolderOfAuthorisation
	{
		[JsonProperty("op_type")]
		public string op_type { get; set; } = "create";
		[JsonProperty("auth_role_id")]
		public string auth_role_id { get; set; }

		[JsonProperty("auth_type_code")]
		public string auth_type_code { get; set; }
	}

}
