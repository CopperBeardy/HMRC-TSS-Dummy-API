using FakeTradeSupportService.Models;
using FakeTradeSupportService.Models.Goods;
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
	public class GoodsController : ControllerBase
	{
		[HttpPost]
		public async Task<IActionResult> GoodsDeclaration(GoodsRequest goodsRequest)
		{
			if (goodsRequest == null)
				return BadRequest();
			return Ok(await GetResponse(goodsRequest));
		}
		[HttpGet]
		public IActionResult GetGoodsDetails([FromHeader] GoodsDetailsRequest goodsDetailRequest)
		{
			if (goodsDetailRequest == null || String.IsNullOrEmpty(goodsDetailRequest.fields))
				return BadRequest();

			var header = CreateFake(goodsDetailRequest.goods_ref_number);
			var result = new Goods() { goods_ref_number = goodsDetailRequest.goods_ref_number };

			foreach (var prop in typeof(Goods).GetProperties())
			{
				if (goodsDetailRequest.fields.Split(',').Contains(prop.Name))
				{
					prop.SetValue(result, prop.GetValue(header));
				}
			}
			return Ok(result);
		}

		[HttpGet("lookup")]
		public IActionResult GetGoods([FromHeader]GoodsLookup goodsLookup)
		{
			if (goodsLookup == null)
				return BadRequest();

			return !String.IsNullOrEmpty(goodsLookup.sfd_number)
				? Ok(new sfdlookup()
				{
					sfd_number = goodsLookup.sfd_number,
					Goods = GetLookupGoods()
				})
				: Ok(new suplookup()
				{
					sup_dec_number = goodsLookup.sup_dec_number,
					Goods = GetLookupGoods()
				});
		}

		private static LookupItem[] GetLookupGoods() => new LookupItem[]
				{
				new LookupItem()
				{
					reference= "576435dc1b8da450e159620be54bcbec",
					goods_description= "Car parts",
					package_marks= "345"
				},
				new LookupItem()
				{
					reference= "03a9efc01b256c1004473325464bcb09",
					goods_description= "Body panels",
					package_marks= "A91262"
				},
			new LookupItem(){
				reference= "03ca614f1b0d24107a49db5be54bcbff",
				goods_description= "Suspension brackets",
				package_marks= "34544421"
			}
				};

		private async static Task<StandardResponse> GetResponse(GoodsRequest goodsRequest)
		{
			await LongTaskSim.WaitFive();
			var resp = new StandardResponse() { process_message = "Success" };
			if (goodsRequest.op_type == "create")
			{
				resp.status = "inserted";
				resp.reference = Guid.NewGuid().ToString().ToString().Replace("-", "");
			}
			else if (goodsRequest.op_type == "update" || goodsRequest.op_type == "submit")
			{
				resp.status = "updated";
				resp.reference = goodsRequest.goods_ref_number;
			}
			else if (goodsRequest.op_type == "delete")
			{
				resp.status = "deleted";
				resp.reference = goodsRequest.goods_ref_number;
			}

			return resp;
		}

		private static GoodsRequest CreateFake(string itemNumber) => new GoodsRequest()
		{

			op_type = "create",
			consignment_number = "DEC000000000002051",
			goods_ref_number = itemNumber,
			equipment_number = "",
			un_dangerous_goods_code = "",
			type_of_packages = "boxes",
			number_of_packages = "1",
			number_of_individual_pieces = "",
			package_marks = "ADDR",
			gross_mass_kg = "400",
			net_mass_kg = "",
			goods_description = "Car parts",
			invoice_number = "INV123",
			controlled_goods = "true",
			controlled_goods_type = "weapons",
			commodity_code = "106120000",
			country_of_origin = "ES",
			item_invoice_amount = "100.00",
			item_invoice_currency = "",
			procedure_code = "",
			additional_procedure_code = "",
			taric_code = "",
			cus_code = "",
			national_additional_codes = "",
			u_ni_additional_information_codes = "",
			supplementary_units = "",
			tax_base_unit = "",
			tax_base_quantity = "",
			additional_procedures = new AdditionalProcedure[]
			{
				new AdditionalProcedure()
				{
					op_type= "create",
					additional_procedure_code= "D11"
				},
				new AdditionalProcedure()
				{
					op_type= "create",
					additional_procedure_code= "D21"
				},
				new AdditionalProcedure()
				{
					op_type= "create",
					additional_procedure_code= "D16"
				},
				new AdditionalProcedure()
				{
					op_type= "create",
					additional_procedure_code= "D51"
				}
			},
			document_references = new DocumentReference[]
			{
				new DocumentReference()
				{
					op_type= "create",
					document_code= "D019",
					document_reference= "doc12345",
					document_status= "AT",
					document_part= "",
					document_reason= "",
					date_of_validity= "",
					issuing_authority= "",
					currency= "",
					measurement_unit= "",
					quantity= ""
				}
			},
			additional_information = new AdditionalInformation[]
			{
				new AdditionalInformation()
				{
					op_type= "create",
					additional_info_code= "AG202",
					additional_info_description= ""
				}
			},
			detail_previous_document = new DetailPreviousDocument[]
			{
				new DetailPreviousDocument()
				{
					op_type= "create",
					previous_document_ref= "Ref1234",
					previous_document_type= "740",
					previous_document_class= "X"
				},
				new DetailPreviousDocument()
				{
					op_type= "create",
					previous_document_ref= "Ref5678",
					previous_document_type= "741",
					previous_document_class= "Y"
				}
			},
			item_add_ded = new ItemAddDed[]
			{
				new ItemAddDed()
				{
					op_type= "create",
					item_add_ded_code= "AM",
					Item_add_ded_value= "100"
				},
				new ItemAddDed()
				{
					op_type= "create",
					item_add_ded_code= "BB",
					Item_add_ded_value= "50"
				}
			}
		};
}
}
