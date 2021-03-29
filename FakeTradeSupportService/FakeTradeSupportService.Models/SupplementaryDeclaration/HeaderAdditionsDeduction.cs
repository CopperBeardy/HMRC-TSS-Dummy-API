using Newtonsoft.Json;

namespace FakeTradeSupportService.Models.SupplementaryDeclaration
{
	public class HeaderAdditionsDeduction
	{
		[JsonProperty("op_type")]
		public string op_type { get; set; }

		[JsonProperty("addition_deduction_code")]
		public string addition_deduction_code { get; set; }

		[JsonProperty("addition_deduction_value")]
		public string addition_deduction_value { get; set; }
	}

}
