using Newtonsoft.Json;

namespace FakeTradeSupportService.Models
{

	public class HeaderPreviousDocument
	{
		[JsonProperty("op_type")]
		public string op_type { get; set; } = "create";

		[JsonProperty("previous_document_class")]
		public string previous_document_class { get; set; }

		[JsonProperty("previous_document_type")]
		public string previous_document_type { get; set; }

		[JsonProperty("previous_document_ref")]
		public string previous_document_ref { get; set; }
	}

}
