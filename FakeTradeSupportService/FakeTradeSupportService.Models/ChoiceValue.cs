using Newtonsoft.Json;

namespace FakeTradeSupportService.Models
{

	namespace JsonModels
	{
		public class ChoiceValue
		{
			[JsonProperty("value")]
			public string Value { get; set; }

			[JsonProperty("name")]
			public string Name { get; set; }
		}
	}
}
