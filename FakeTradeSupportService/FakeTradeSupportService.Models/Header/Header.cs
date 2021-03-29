using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace FakeTradeSupportService.Models.Header
{
	public class Header : StatusOf
	{

		[JsonProperty("declaration_number")]
		[StringLength(40, ErrorMessage = "should be less than 40 characters")]
		public string declaration_number { get; set; }

		[JsonProperty("movement_type")]
		[StringLength(40, ErrorMessage = "should be less than 40 characters")]
		public string movement_type { get; set; }

		[JsonProperty("identity_no_of_transport")]
		[StringLength(27, ErrorMessage = "Should be 27 characters")]
		public string identity_no_of_transport { get; set; }

		[JsonProperty("nationality_of_transport")]
		public string nationality_of_transport { get; set; }

		[JsonProperty("conveyance_ref")]
		public string conveyance_ref { get; set; }

		[JsonProperty("arrival_date_time")]
		public string arrival_date_time { get; set; }

		[JsonProperty("arrival_port")]
		public string arrival_port { get; set; }

		[JsonProperty("place_of_loading")]
		public string place_of_loading { get; set; }

		[JsonProperty("place_of_unloading")]
		public string place_of_unloading { get; set; }

		[JsonProperty("seal_number")]
		public string seal_number { get; set; }

		[JsonProperty("route")]
		public string route { get; set; }

		[JsonProperty("transport_charges")]
		public string transport_charges { get; set; }

		[JsonProperty("carrier_eori")]
		public string carrier_eori { get; set; }

		[JsonProperty("carrier_name")]
		public string carrier_name { get; set; }

		[JsonProperty("carrier_street_number")]
		public string carrier_street_number { get; set; }

		[JsonProperty("carrier_city")]
		public string carrier_city { get; set; }

		[JsonProperty("carrier_postcode")]
		public string carrier_postcode { get; set; }

		[JsonProperty("carrier_country")]
		public string carrier_country { get; set; }

		[JsonProperty("haulier_eori")]
		public string haulier_eori { get; set; }
	}
}
