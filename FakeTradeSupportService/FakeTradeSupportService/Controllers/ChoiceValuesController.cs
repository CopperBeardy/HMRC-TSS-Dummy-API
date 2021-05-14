using FakeTradeSupportService.Models;
using FakeTradeSupportService.Models.JsonModels;
using Microsoft.AspNetCore.Mvc;

namespace FakeTradeSupportService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ChoiceValuesController : ControllerBase
	{
		// country
		//		country_of_origin
		//		country_of_preferential_origin
		//		exporter_country
		//		importer_country
		//		consignee_country
		//		consignor_country
		//		carrier_country
		//		nationality_of_transport
		//		delivery_location_country
		[HttpGet("country")]
		public IActionResult GetCountry()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
{
				 new ChoiceValue() { Value = "Uk", Name = "United Kingdom" },
				 new ChoiceValue() { Value = "Ro", Name = "Ireland" },
				 new ChoiceValue() { Value = "Fr", Name = "France" }
};

			return Ok(result);
		}


		//movement_type
		//		movement_type
		[HttpGet("movement_type")]
		public IActionResult GetMovementType()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
					{
						new ChoiceValue() { Value = "Air", Name = "Air Frieght" },
						new ChoiceValue() { Value = "Sea", Name = "Sea Frieght" },
						new ChoiceValue() { Value = "Land", Name = "Land Frieght" }
					};
			return Ok(result);
		}

		//port
		//		arrival_port
		[HttpGet("port")]
		public IActionResult GetArrivalPort()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
{
				new ChoiceValue(){ Value="SEFNDSJGF", Name="Bristol"},
				new ChoiceValue(){ Value="FFJSDFHJD", Name="Calais"},
				new ChoiceValue(){ Value="WEOMNNVD", Name="Singapore"},
				new ChoiceValue(){ Value="PIMFEAXCED", Name="New York"}
};
			return Ok(result);
		}

		//route
		//		route
		[HttpGet("route")]
		public IActionResult GetRoute()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
			{
				new ChoiceValue(){Value="RouteA", Name="Route A"},
				new ChoiceValue(){Value="RouteB", Name="Route B"},
				new ChoiceValue(){Value="RouteC", Name="Route C"}
			};
			return Ok(result);
		}

		//transport_charges
		//		transport_charge
		[HttpGet("transport_charges")]
		public IActionResult GetTransportCharges()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
					{
					new ChoiceValue(){Value="Export", Name="Export" },
					new ChoiceValue(){Value="Import", Name="Import" },
					new ChoiceValue(){Value="Vat", Name="Vat" }
					};
			return Ok(result);
		}

		//type_of_packages
		//		type_of_packages
		[HttpGet("type_of_packages")]
		public IActionResult GetTypeOfPackage()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
					{
						new ChoiceValue() { Value = "Pallet", Name = "Pallet" },
						new ChoiceValue() { Value = "Barrel", Name = "Barrel" },
						new ChoiceValue() { Value = "Container", Name = "Container" }
					};
			return Ok(result);
		}

		//controlled_goods_type
		//		controlled_goods_type
		[HttpGet("controlled_goods_type")]
		public IActionResult GetControlledGoodsType()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
			{
					new ChoiceValue(){Value="Electronic", Name="Electronic" },
					new ChoiceValue(){Value="Barrel", Name="Barrel" },
					new ChoiceValue(){Value="Container", Name="Container" }
		};
			return Ok(result);
		}

		//commodity_code
		//		commodity_code
		[HttpGet("commodity_code")]
		public IActionResult GetCommodityCode()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
		{
					new ChoiceValue(){Value="Heading8833", Name="Wing" },
					new ChoiceValue(){Value="Heading8820", Name="Engine" },
					new ChoiceValue(){Value="Heading8812", Name="Tyre" }
	};
			return Ok(result);
		}

		//goods_location
		//		goods_location
		[HttpGet("goods_location")]
		public IActionResult GetGoodsLocation()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
				{
					new ChoiceValue(){Value="London", Name="London" },
					new ChoiceValue(){Value="Derry", Name="Derry" },
					new ChoiceValue(){Value="Stockholm", Name="Stockholm" }
};
			return Ok(result);
		}

		//incoterm
		//		incoterm
		[HttpGet("incoterm")]
		public IActionResult GetIncoterm()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
				{
				new ChoiceValue(){Value="DAP", Name="DAP" },
				new ChoiceValue(){Value="LDD", Name="LDD" },
				new ChoiceValue(){Value="RTZ", Name="RTZ" }
	};
			return Ok(result);
		}

		//addition_deduction_code
		//		addition_deduction_code
		[HttpGet("addition_deduction_code")]
		public IActionResult GetAdditionDeductionCode()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
		{
					new ChoiceValue(){Value="DE", Name="DE" },
					new ChoiceValue(){Value="TR", Name="TR" },
					new ChoiceValue(){Value="VB", Name="VB" }
};
			return Ok(result);
		}

		//procedure_code
		//		procedure_code
		[HttpGet("procedure_code")]
		public IActionResult GetProcedureCode()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
		{
					new ChoiceValue(){Value="GLHK", Name="GLHK" },
					new ChoiceValue(){Value="OPDF", Name="OPDF" },
					new ChoiceValue(){Value="MMNN", Name="MMNN" }
};
			return Ok(result);
		}


		//national_additional_codes
		//		national_additional_codes
		[HttpGet("national_additional_codes")]
		public IActionResult GetNationalAdditionalCodes()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
		{
					new ChoiceValue(){Value="PPOO", Name="PPOO" },
					new ChoiceValue(){Value="LLKK", Name="LLKK" },
					new ChoiceValue(){Value="MKLK", Name="MKLK" }
};
			return Ok(result);
		}

		//additional_procedure_code
		//		additional_procedure_code
		[HttpGet("additional_procedure_code")]
		public IActionResult GetAdditionalProcedureCode()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
		{
					new ChoiceValue(){Value="PPP", Name="PPP" },
					new ChoiceValue(){Value="BBB", Name="BBB" },
					new ChoiceValue(){Value="CCC", Name="CCC" }
	};
			return Ok(result);
		}

		//document_code
		//		document_code
		[HttpGet("document_code")]
		public IActionResult GetDocumentCode()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
		{
				new ChoiceValue(){Value="RRTE", Name="RRTE" },
				new ChoiceValue(){Value="YYTT", Name="YYTT" },
				new ChoiceValue(){Value="CCXX", Name="CCXX" }
};
			return Ok(result);
		}

		//document_status
		//		document_status
		[HttpGet("document_status")]
		public IActionResult GetDocumentStatus()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
		{
					new ChoiceValue(){Value="XX", Name="XX" },
					new ChoiceValue(){Value="YY", Name="YY" },
					new ChoiceValue(){Value="XY", Name="XY" }
};
			return Ok(result);
		}

		//item_add_ded_code
		//		item_add_ded_code
		[HttpGet("item_add_ded_code")]
		public IActionResult GetItemAddDedCode()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
		{
					new ChoiceValue(){Value="AM", Name="AM" },
					new ChoiceValue(){Value="MA", Name="MA" },
					new ChoiceValue(){Value="CV", Name="CV" }
};
			return Ok(result);
		}

		//measurement_unit
		//		measurement_unit
		[HttpGet("measurement_unit")]
		public IActionResult GetMeasurementUnit()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
		{
					new ChoiceValue(){Value="Kg", Name="Kg" },
					new ChoiceValue(){Value="Ton", Name="Ton" },
					new ChoiceValue(){Value="Gal", Name="Gallon" }
};
			return Ok(result);
		}

		//previous_document_type
		//		previous_document_type
		[HttpGet("previous_document_type")]
		public IActionResult GetPreviousDocumentType()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
			{
					new ChoiceValue(){Value="730", Name="730" },
					new ChoiceValue(){Value="800", Name="800" },
					new ChoiceValue(){Value="332", Name="332" }
	};
			return Ok(result);
		}

		//previous_document_class
		//		previous_document_class
		[HttpGet("previous_document_class")]
		public IActionResult GetPreviousDocumentClass()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
				{
					new ChoiceValue(){Value="X", Name="X" },
					new ChoiceValue(){Value="Y", Name="Y" },
					new ChoiceValue(){Value="Z", Name="Z" }
	};
			return Ok(result);
		}

		//additional_info_code
		//		additional_info_code
		[HttpGet("additional_info_code")]
		public IActionResult GetAdditionalInfoCode()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
				{
					new ChoiceValue(){Value="PS342", Name="PS342" },
					new ChoiceValue(){Value="IO222", Name="IO222" },
					new ChoiceValue(){Value="JK343", Name="JK343" }
		};
			return Ok(result);
		}

		//auth_type_code
		//		auth_type_code
		[HttpGet("auth_type_code")]
		public IActionResult GetAuthTypeCode()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
				{
				new ChoiceValue(){Value="SDE", Name="SDE" },
				new ChoiceValue(){Value="QWE", Name="QWE" },
				new ChoiceValue(){Value="CXC", Name="CXC" }
		};
			return Ok(result);
		}

		//goods_domestic_status
		//		goods_domestic_status
		[HttpGet("goods_domestic_status")]
		public IActionResult GetGoodsDomesticStatus()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
				{
				new ChoiceValue(){Value="D", Name="D" },
				new ChoiceValue(){Value="W", Name="W" },
				new ChoiceValue(){Value="J", Name="J" }
		};
			return Ok(result);
		}

		//supervising_customs_office
		//		supervising_customs_office
		[HttpGet("supervising_customs_office")]
		public IActionResult GetSupervisingCustomsOffice()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
				{
				new ChoiceValue(){Value="MOCNEDHT", Name="Uk" },
				new ChoiceValue(){Value="BRETESWS", Name="Ro" },
				new ChoiceValue(){Value="CLLLKFSS", Name="Fr" }
		};
			return Ok(result);
		}

		//tax_base_unit
		//		tax_base_unit
		[HttpGet("tax_base_unit")]
		public IActionResult GetTaxBaseUnit()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
				{
				new ChoiceValue(){Value="1752", Name="1752" },
				new ChoiceValue(){Value="2222", Name="2222" },
				new ChoiceValue(){Value="2123", Name="2123" }
			};
			return Ok(result);
		}

		//currency
		//		currency
		//		addition_deduction_currency
		//		item_add_ded_currency
		//		total_invoice_currency
		//		freight_charge_currency
		//		vat_adjust_currency
		//		insurance_currency
		[HttpGet("currency")]
		public IActionResult GetCurrency()
		{
			var result = new ChoiceValueResult();
			result.result = new ChoiceValue[]
				{
				new ChoiceValue(){Value="GBP", Name="GBP" },
				new ChoiceValue(){Value="EURO", Name="EURO" },
				new ChoiceValue(){Value="USD", Name="USD" }
			};
			return Ok(result);
		}
	}
}
