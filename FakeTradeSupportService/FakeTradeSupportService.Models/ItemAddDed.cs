using Newtonsoft.Json;

namespace FakeTradeSupportService.Models
{
	public class ItemAddDed
	{
		[JsonProperty("op_type")]
		public string op_type { get; set; }

		[JsonProperty("item_add_ded_code")]
		public string item_add_ded_code { get; set; }

		[JsonProperty("Item_add_ded_value")]
		public string Item_add_ded_value { get; set; }


	}
}
