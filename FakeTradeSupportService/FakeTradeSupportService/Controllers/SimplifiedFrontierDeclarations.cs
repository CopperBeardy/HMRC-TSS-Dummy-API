using FakeTradeSupportService.Models;
using FakeTradeSupportService.Models.SimplifiedFrontierDeclaration;
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
	public class SimplifiedFrontierDeclarations : ControllerBase
	{
		[HttpPost]
		public async Task<IActionResult> SFDUpdate(SFDRequest sFDRequest)
		{
			if (sFDRequest == null)
				return BadRequest();
			await LongTaskSim.WaitFive();
			var result = new StandardResponse()
			{
				status = "updated",
				reference = sFDRequest.sfd_number,
				process_message = "Success"
			};
			return Ok(result);
		}
		[HttpGet("simplified_frontier_declarations")]
		public async Task<IActionResult> Lookup([FromHeader] SFD_LookupResponse lookupResponse)
		{
			if (lookupResponse == null)
				return BadRequest();
			lookupResponse.sfd_number = "DEC000000000001182";
			await LongTaskSim.WaitFive();
			return Ok(lookupResponse);
		}

		[HttpGet]
		public IActionResult Read([FromHeader]SFD_DetailRequest sFD_DetailRequest)
		{
			var fakeObjec = CreateFake(sFD_DetailRequest.sfd_number);
			var result = new SimplifiedFrontierDeclaration() { sfd_number = sFD_DetailRequest.sfd_number };
			foreach (var prop in typeof(SimplifiedFrontierDeclaration).GetProperties())
			{
				if(sFD_DetailRequest.fields.Split(',').Contains(prop.Name))
				{
					var value = prop.GetValue(fakeObjec);
					prop.SetValue(result, value);

				}
			}
			return Ok(result);
		}


		private static SFDRequest CreateFake(string sfdnumber) => new SFDRequest()
		{
			op_type = "update",
			sfd_number = sfdnumber,
			goods_description = "Car parts",
			transport_document_reference = "REF12345",
			controlled_goods = "true",
			goods_domestic_status = "D",
			supervising_customs_office = "",
			customs_warehouse_identifier = "",
			ducr = "",
			consignor_eori = "XI123456789012",
			consignor_name = "",
			consignor_street_number = "",
			consignor_city = "",
			consignor_postcode = "",
			consignor_country = "",
			consignee_eori = "",
			consignee_name = "John Doe",
			consignee_street_number = "12 Street",
			consignee_city = "Belfast",
			consignee_postcode = "BT1 1AA",
			consignee_country = "GB",
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
			holder_of_authorisation = new HolderOfAuthorisation[]
			{
				new HolderOfAuthorisation()
				{
					op_type= "create",
					auth_role_id= "GB000012340001",
					auth_type_code= "SDE"
				}
			},
			status = "Authorized for movement"
		};
	}
}
