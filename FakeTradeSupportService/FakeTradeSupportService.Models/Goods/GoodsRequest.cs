using Newtonsoft.Json;

namespace FakeTradeSupportService.Models.Goods
{
	public class GoodsRequest : Goods
	{

		[JsonProperty("op_type")]
		public string op_type { get; set; } = "create";

	}
}
