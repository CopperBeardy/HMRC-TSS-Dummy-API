using Newtonsoft.Json;

namespace FakeTradeSupportService.Models.SupplementaryDeclaration
{
	public class SupplementaryDeclarationUpdateRequest : SupplementaryDeclaration
	{
		[JsonProperty("op_type")]
		public string op_type { get; set; } = "update";
	}
}
