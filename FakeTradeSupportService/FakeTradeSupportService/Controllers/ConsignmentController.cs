using FakeTradeSupportService.Models;
using FakeTradeSupportService.Models.Consignments;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FakeTradeSupportService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ConsignmentController : ControllerBase
	{
		[HttpPost]
		public async Task<IActionResult> ConsignmentDeclaration(ConsignmentRequest consignmentRequest)
		{
			if (consignmentRequest == null)
				return BadRequest();
			return Ok( await GetResponse(consignmentRequest));
		}
		[HttpGet]
		public IActionResult GetConsignmentDetails([FromHeader] ConsignmentDetailRequest consignmentDetailRequest)
		{
			if (consignmentDetailRequest == null || String.IsNullOrEmpty(consignmentDetailRequest.fields))
				return BadRequest();
			var header = CreateFake(consignmentDetailRequest.consignment_number);
			var result = new Consignment() {  consignment_number = consignmentDetailRequest.consignment_number };


			foreach (var prop in typeof(Consignment).GetProperties())
			{
				if (consignmentDetailRequest.fields.Split(',').Contains(prop.Name))
				{
					var value = prop.GetValue(header);
					prop.SetValue(result, value);
				}
			}
			return Ok(result);
		}
		private async static Task<StandardResponse> GetResponse(ConsignmentRequest consignmentRequest)
		{
			await LongTaskSim.WaitFive();
			var resp = new StandardResponse() { process_message = "Success" };
			if (consignmentRequest.op_type == "create")
			{
				var random = new Random(1000);
				var num = random.Next(9000);

				resp.status = "inserted";
				resp.reference = $"DEC00000000000{num}";
			}
			else if (consignmentRequest.op_type == "update" || consignmentRequest.op_type == "cancel" || consignmentRequest.op_type == "submit")
			{
				resp.status = "updated";
				resp.reference = consignmentRequest.consignment_number;
			}

			return resp;
		}
		public static Consignment CreateFake(string consignmentNumber) => new Consignment()
		{

			declaration_number = "ENS000000000001577",
			consignment_number = consignmentNumber,
			goods_description = "Car parts",
			transport_document_number = "REF12345",
			controlled_goods = "true",
			goods_domestic_status = "D",
			supervising_customs_office = "Derry",
			customs_warehouse_identifier = "d1123123",
			ducr = "w2345gd",
			consignor_eori = "XI123456789012",
			consignor_name = "MAgicsupplies",
			consignor_street_number = "12 kazaam lane",
			consignor_city = "abracadabra",
			consignor_postcode = "a76 a89",
			consignor_country = "en-ni",
			consignee_eori = "aodoafasfasf",
			consignee_name = "John Doe",
			consignee_street_number = "12 Street",
			consignee_city = "Belfast",
			consignee_postcode = "BT1 1AA",
			consignee_country = "GB",
			importer_eori = "GB1234567890123",
			importer_name = "Magic are us",
			importer_street_number = "23a watertake lane",
			importer_city = "Cork",
			importer_postcode = "cd45 34j",
			importer_country = "ir",
			exporter_eori = "GB12345678901234",
			exporter_name = "12 exporters",
			exporter_street_number = "54 sendaway place",
			exporter_city = "newport",
			exporter_postcode = "nw23 2ds",
			exporter_country = "wales",
			header_previous_document = new HeaderPreviousDocument[] { new HeaderPreviousDocument {
				previous_document_class = "X",
				previous_document_type = "355",
				previous_document_ref = "80085"
				} },
			holder_of_authorisation = new HolderOfAuthorisation[] { new HolderOfAuthorisation
			{
				auth_role_id = "GB000012340001",
				auth_type_code = "SDE"
			} },
			status = "onRoute"
		};
	}
}
