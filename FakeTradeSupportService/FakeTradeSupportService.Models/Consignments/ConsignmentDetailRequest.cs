using Newtonsoft.Json;

namespace FakeTradeSupportService.Models.Consignments
{
	public class ConsignmentDetailRequest
	{
		[JsonProperty("consignment_number")]
		public string consignment_number { get; set; }

		[JsonProperty("fields")]
		public string fields { get; set; }
	}
}
