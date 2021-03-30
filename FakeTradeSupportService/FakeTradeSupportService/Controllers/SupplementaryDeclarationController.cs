using FakeTradeSupportService.Models;
using FakeTradeSupportService.Models.SimplifiedFrontierDeclaration;
using FakeTradeSupportService.Models.SupplementaryDeclaration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeTradeSupportService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SupplementaryDeclarationController : ControllerBase
	{
		[HttpPost]
		public async Task<IActionResult> SDUpdate(SDRequest sDRequest)
		{
			if (sDRequest == null)
				return BadRequest();
			await LongTaskSim.WaitFive();
			var result = new StandardResponse()
			{
				status = "updated",
				reference = sDRequest.supp_dec_number,
				process_message = "Success"
			};
			return Ok(result);
		}

		[HttpGet("supplementary_declarations")]
		public async Task<IActionResult> Lookup([FromHeader] SD_LookupResponse lookupResponse)
		{
			if (lookupResponse == null)
				return BadRequest();
			lookupResponse.sup_dec_number = "DEC000000000005499";
			await LongTaskSim.WaitFive();
			return Ok(lookupResponse);
		}

		[HttpGet]
		public IActionResult Read([FromHeader] SD_DetailRequest sD_DetailRequest)
		{
			var fakeObjec = CreateFake(sD_DetailRequest.supp_dec_number);
			var result = new SDRequest() {supp_dec_number = sD_DetailRequest.supp_dec_number };
			foreach (var prop in typeof(SDRequest).GetProperties())
			{
				if (sD_DetailRequest.fields.Split(',').Contains(prop.Name))
				{
					var value = prop.GetValue(fakeObjec);
					prop.SetValue(result, value);

				}
			}
			return Ok(result);
		}

		public static SDRequest CreateFake(string supNumber) => new SDRequest()
		{

			op_type = "update",
			supp_dec_number = "SUP000000000001077",
			controlled_goods = "true",
			additional_procedure = "false",
			goods_domestic_status = "D",
			importer_eori = "GB1234567890123",
			importer_name = "",
			importer_street_number = "",
			importer_city = "",
			importer_postcode = "",
			importer_country = "",
			exporter_eori = "GB12345678901234",
			exporter_name = "",
			exporter_street_number = "",
			exporter_city = "",
			exporter_postcode = "",
			exporter_country = "",
			total_packages = "12",
			movement_type = "3",
			nationality_of_transport = "GB",
			identity_number_of_transport = "HD60 1XL XX1254POL",
			freight_charge = "",
			freight_charge_currency = "",
			insurance = "",
			insurance_currency = "",
			vat_adjustment = "",
			vat_adjustment_currency = "",
			total_invoice = "",
			total_invoice_currency = "",
			exchange_rate = "",
			goods_location = "Londonderry",
			postponed_vat = "false",
			vat_number = "",
			incoterm = "DAP",
			delivery_location_country = "GB",
			delivery_location_town = "Belfast",
			header_previous_document = new HeaderPreviousDocument[]
			{
				new HeaderPreviousDocument()
				{
					op_type= "create",
					previous_document_class= "X",
					previous_document_type= "355",
					previous_document_ref= "80085"
				}
			},
			holder_of_authorisation= new HolderOfAuthorisation[]
			{
				new HolderOfAuthorisation()
				{
					op_type= "create",
					auth_role_id= "GB000012340001",
					auth_type_code= "SDE"
				}
			},
			header_additions_deductions= new HeaderAdditionsDeduction[]
			{
				new HeaderAdditionsDeduction()
				{
					op_type= "create",
					addition_deduction_code= "AE",
					addition_deduction_value= "150"
				}
			},
			status = "closed"
		};
	}
}
