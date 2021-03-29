using Newtonsoft.Json;

namespace FakeTradeSupportService.Models
{
	public class AdditionalProcedure
	{
		[JsonProperty("op_type")]
		public string op_type { get; set; }

		[JsonProperty("additional_procedure_code")]
		public string additional_procedure_code { get; set; }
	}
}
