using Newtonsoft.Json;

namespace FakeTradeSupportService.Models.SimplifiedFrontierDeclaration
{
	public class SimplifiedFrontierDeclaration
	{

		[JsonProperty("sfd_number")]
		public string sfd_number { get; set; }

		[JsonProperty("goods_description")]
		public string goods_description { get; set; }

		[JsonProperty("transport_document_reference")]
		public string transport_document_reference { get; set; }

		[JsonProperty("controlled_goods")]
		public string controlled_goods { get; set; }

		[JsonProperty("goods_domestic_status")]
		public string goods_domestic_status { get; set; }

		[JsonProperty("supervising_customs_office")]
		public string supervising_customs_office { get; set; }

		[JsonProperty("customs_warehouse_identifier")]
		public string customs_warehouse_identifier { get; set; }

		[JsonProperty("ducr")]
		public string ducr { get; set; }

		[JsonProperty("consignor_eori")]
		public string consignor_eori { get; set; }

		[JsonProperty("consignor_name")]
		public string consignor_name { get; set; }

		[JsonProperty("consignor_street_number")]
		public string consignor_street_number { get; set; }

		[JsonProperty("consignor_city")]
		public string consignor_city { get; set; }

		[JsonProperty("consignor_postcode")]
		public string consignor_postcode { get; set; }

		[JsonProperty("consignor_country")]
		public string consignor_country { get; set; }

		[JsonProperty("consignee_eori")]
		public string consignee_eori { get; set; }

		[JsonProperty("consignee_name")]
		public string consignee_name { get; set; }

		[JsonProperty("consignee_street_number")]
		public string consignee_street_number { get; set; }

		[JsonProperty("consignee_city")]
		public string consignee_city { get; set; }

		[JsonProperty("consignee_postcode")]
		public string consignee_postcode { get; set; }

		[JsonProperty("consignee_country")]
		public string consignee_country { get; set; }

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

		[JsonProperty("header_previous_document")]
		public HeaderPreviousDocument[] header_previous_document { get; set; }

		[JsonProperty("holder_of_authorisation")]
		public HolderOfAuthorisation[] holder_of_authorisation { get; set; }

	}
}
