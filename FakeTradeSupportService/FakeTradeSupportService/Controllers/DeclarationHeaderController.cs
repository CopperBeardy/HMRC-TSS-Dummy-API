using FakeTradeSupportService.Models;
using FakeTradeSupportService.Models.Header;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FakeTradeSupportService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DeclarationHeaderController : ControllerBase
	{
		[HttpPost]
		public async Task<IActionResult> Header([FromBody] HeaderRequest headerRequest)
		{
			if (headerRequest == null)
				return BadRequest();
			return Ok(await GetResponse(headerRequest));
		}

		[HttpGet]
		public IActionResult GetHeaderDetails([FromHeader] HeaderDetailsRequest headerDetailsRequest)
		{
			if (headerDetailsRequest == null || String.IsNullOrEmpty(headerDetailsRequest.fields))
				return BadRequest();
			var header = CreateFake(headerDetailsRequest.declaration_number);
			var result = new Header() { declaration_number = headerDetailsRequest.declaration_number };


			foreach (var prop in typeof(Header).GetProperties())
			{
				if (headerDetailsRequest.fields.Split(',').Contains(prop.Name))
				{
					prop.SetValue(result, prop.GetValue(header));
				}
			}
			return Ok(result);
		}


		/*function is to simulate creating the response message 
		 which would normaly be generated with data from database service;
		 */
		private async static Task<StandardResponse> GetResponse(HeaderRequest header)
		{
			await LongTaskSim.WaitFive();
			var resp = new StandardResponse() { process_message = "SUCCESS" };
			if (header.op_type == "create")
			{
				var random = new Random(1000);
				var num = random.Next(9000);

				resp.status = "inserted";
				resp.reference = $"ENS00000000000{num}";
			}
			else if (header.op_type == "update" || header.op_type == "cancel")
			{
				resp.status = "updated";
				resp.reference = header.declaration_number;
			}

			return resp;
		}

		private static Header CreateFake(string num) => new Header()
		{
			declaration_number = num,
			movement_type = "3",
			identity_no_of_transport = "xy12345",
			nationality_of_transport = "GB",
			conveyance_ref = "",
			arrival_date_time = "25/01/2021 10:00:00",
			arrival_port = "GBAUBELBELBEL",
			place_of_loading = "Birkenhead",
			place_of_unloading = "Belfast",
			seal_number = "s123456",
			route = "gb-ni",
			transport_charges = "Y",
			carrier_eori = "XI123456789012",
			carrier_name = "fastpart",
			carrier_street_number = "11 erewf",
			carrier_city = "jaggerville",
			carrier_postcode = "j789dk",
			carrier_country = "gb-en",
			haulier_eori = "sdgdsdg"
		};
	}
}
