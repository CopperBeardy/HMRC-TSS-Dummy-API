using Newtonsoft.Json;

namespace FakeTradeSupportService.Models
{
	public class DocumentReference
	{
		[JsonProperty("op_type")]
		public string op_type { get; set; }

		[JsonProperty("document_code")]
		public string document_code { get; set; }

		[JsonProperty("document_reference")]
		public string document_reference { get; set; }

		[JsonProperty("document_status")]
		public string document_status { get; set; }

		[JsonProperty("document_part")]
		public string document_part { get; set; }

		[JsonProperty("document_reason")]
		public string document_reason { get; set; }

		[JsonProperty("date_of_validity")]
		public string date_of_validity { get; set; }

		[JsonProperty("issuing_authority")]
		public string issuing_authority { get; set; }

		[JsonProperty("currency")]
		public string currency { get; set; }

		[JsonProperty("measurement_unit")]
		public string measurement_unit { get; set; }

		[JsonProperty("quantity")]
		public string quantity { get; set; }
	}

}
