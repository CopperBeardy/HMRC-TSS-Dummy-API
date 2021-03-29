using Newtonsoft.Json;

namespace FakeTradeSupportService.Models.Goods
{
	public class GoodsDetailsRequest : Goods
	{
		[JsonProperty("goods_ref_number")]
		public string goods_ref_number { get; set; }

		[JsonProperty("fields")]
		public string fields { get; set; }
	}
}
