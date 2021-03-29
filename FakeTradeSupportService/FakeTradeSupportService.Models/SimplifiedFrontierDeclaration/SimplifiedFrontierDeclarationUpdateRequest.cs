using Newtonsoft.Json;

namespace FakeTradeSupportService.Models.SimplifiedFrontierDeclaration
{
	public class SimplifiedFrontierDeclarationUpdateRequest : SimplifiedFrontierDeclaration
	{
		[JsonProperty("op_type")]
		public string op_type { get; set; } = "update";
	}
}
