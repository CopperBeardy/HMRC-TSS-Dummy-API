using Newtonsoft.Json;

namespace FakeTradeSupportService.Models.SupplementaryDeclaration
{
	public class SupplementaryDeclaration : StatusOf
	{

		[JsonProperty("supp_dec_number")]
		public string supp_dec_number { get; set; }

		[JsonProperty("controlled_goods")]
		public string controlled_goods { get; set; }

		[JsonProperty("additional_procedure")]
		public string additional_procedure { get; set; }

		[JsonProperty("goods_domestic_status")]
		public string goods_domestic_status { get; set; }

		[JsonProperty("importer_eori")]
		public string importer_eori { get; set; }

		[JsonProperty("importer_name")]
		public string importer_name { get; set; }

		[JsonProperty("importer_street_number")]
		public string importer_street_number { get; set; }

		[JsonProperty("importer_city")]
		public string importer_city { get; set; }

		[JsonProperty("importer_postcode")]
		public string importer_postcode { get; set; }

		[JsonProperty("importer_country")]
		public string importer_country { get; set; }

		[JsonProperty("exporter_eori")]
		public string exporter_eori { get; set; }

		[JsonProperty("exporter_name")]
		public string exporter_name { get; set; }

		[JsonProperty("exporter_street_number")]
		public string exporter_street_number { get; set; }

		[JsonProperty("exporter_city")]
		public string exporter_city { get; set; }

		[JsonProperty("exporter_postcode")]
		public string exporter_postcode { get; set; }

		[JsonProperty("exporter_country")]
		public string exporter_country { get; set; }

		[JsonProperty("total_packages")]
		public string total_packages { get; set; }

		[JsonProperty("movement_type")]
		public string movement_type { get; set; }

		[JsonProperty("nationality_of_transport")]
		public string nationality_of_transport { get; set; }

		[JsonProperty("identity_number_of_transport")]
		public string identity_number_of_transport { get; set; }

		[JsonProperty("freight_charge")]
		public string freight_charge { get; set; }

		[JsonProperty("freight_charge_currency")]
		public string freight_charge_currency { get; set; }

		[JsonProperty("insurance")]
		public string insurance { get; set; }

		[JsonProperty("insurance_currency")]
		public string insurance_currency { get; set; }

		[JsonProperty("vat_adjustment")]
		public string vat_adjustment { get; set; }

		[JsonProperty("vat_adjustment_currency")]
		public string vat_adjustment_currency { get; set; }

		[JsonProperty("total_invoice")]
		public string total_invoice { get; set; }

		[JsonProperty("total_invoice_currency")]
		public string total_invoice_currency { get; set; }

		[JsonProperty("exchange_rate")]
		public string exchange_rate { get; set; }

		[JsonProperty("goods_location")]
		public string goods_location { get; set; }

		[JsonProperty("postponed_vat")]
		public string postponed_vat { get; set; }

		[JsonProperty("vat_number")]
		public string vat_number { get; set; }

		[JsonProperty("incoterm")]
		public string incoterm { get; set; }

		[JsonProperty("delivery_location_country")]
		public string delivery_location_country { get; set; }

		[JsonProperty("delivery_location_town")]
		public string delivery_location_town { get; set; }

		[JsonProperty("header_previous_document")]
		public HeaderPreviousDocument[] header_previous_document { get; set; }

		[JsonProperty("holder_of_authorisation")]
		public HolderOfAuthorisation[] holder_of_authorisation { get; set; }

		[JsonProperty("header_additions_deductions")]
		public HeaderAdditionsDeduction[] header_additions_deductions { get; set; }
	}
}

