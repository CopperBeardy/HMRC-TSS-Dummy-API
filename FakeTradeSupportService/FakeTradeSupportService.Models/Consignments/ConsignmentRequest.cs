using Newtonsoft.Json;

namespace FakeTradeSupportService.Models.Consignments
{
	public class ConsignmentRequest : Consignment
	{
		[JsonProperty("op_type")]
		public string op_type { get; set; } = "create";
	}
}