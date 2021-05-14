using FakeTradeSupportService.Models.JsonModels;
using Newtonsoft.Json;

namespace FakeTradeSupportService.Models
{
	public class ChoiceValueResult
	{
		[JsonProperty("result")]
		public ChoiceValue[] result { get; set; }
	}
}
