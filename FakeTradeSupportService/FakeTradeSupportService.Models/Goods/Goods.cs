using Newtonsoft.Json;

namespace FakeTradeSupportService.Models.Goods
{
	public class Goods: StatusOf
	{
		[JsonProperty("consignment_number")]
		public string consignment_number { get; set; }

		[JsonProperty("goods_ref_number")]
		public string goods_ref_number { get; set; }

		[JsonProperty("equipment_number")]
		public string equipment_number { get; set; }

		[JsonProperty("un_dangerous_goods_code")]
		public string un_dangerous_goods_code { get; set; }

		[JsonProperty("type_of_packages")]
		public string type_of_packages { get; set; }

		[JsonProperty("number_of_packages")]
		public string number_of_packages { get; set; }

		[JsonProperty("number_of_individual_pieces")]
		public string number_of_individual_pieces { get; set; }

		[JsonProperty("package_marks")]
		public string package_marks { get; set; }

		[JsonProperty("gross_mass_kg")]
		public string gross_mass_kg { get; set; }

		[JsonProperty("net_mass_kg")]
		public string net_mass_kg { get; set; }

		[JsonProperty("goods_description")]
		public string goods_description { get; set; }

		[JsonProperty("invoice_number")]
		public string invoice_number { get; set; }

		[JsonProperty("controlled_goods")]
		public string controlled_goods { get; set; }

		[JsonProperty("controlled_goods_type")]
		public string controlled_goods_type { get; set; }

		[JsonProperty("commodity_code")]
		public string commodity_code { get; set; }

		[JsonProperty("country_of_origin")]
		public string country_of_origin { get; set; }

		[JsonProperty("item_invoice_amount")]
		public string item_invoice_amount { get; set; }

		[JsonProperty("item_invoice_currency")]
		public string item_invoice_currency { get; set; }

		[JsonProperty("procedure_code")]
		public string procedure_code { get; set; }

		[JsonProperty("additional_procedure_code")]
		public string additional_procedure_code { get; set; }

		[JsonProperty("taric_code")]
		public string taric_code { get; set; }

		[JsonProperty("cus_code")]
		public string cus_code { get; set; }

		[JsonProperty("national_additional_codes")]
		public string national_additional_codes { get; set; }

		[JsonProperty("u_ni_additional_information_codes")]
		public string u_ni_additional_information_codes { get; set; }

		[JsonProperty("supplementary_units")]
		public string supplementary_units { get; set; }

		[JsonProperty("tax_base_unit")]
		public string tax_base_unit { get; set; }

		[JsonProperty("tax_base_quantity")]
		public string tax_base_quantity { get; set; }

		[JsonProperty("additional_procedures")]
		public AdditionalProcedure[] additional_procedures { get; set; }

		[JsonProperty("document_references")]
		public DocumentReference[] document_references { get; set; }

		[JsonProperty("additional_information")]
		public AdditionalInformation[] additional_information { get; set; }

		[JsonProperty("detail_previous_document")]
		public DetailPreviousDocument[] detail_previous_document { get; set; }

		[JsonProperty("item_add_ded")]
		public ItemAddDed[] item_add_ded { get; set; }

	}
}