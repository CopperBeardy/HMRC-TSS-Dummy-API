using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeTradeSupportService.Models.Header
{
	public class HeaderDetailsRequest
	{
		[JsonProperty("declaration_number")]	
		public string declaration_number { get; set; }

		[JsonProperty("fields")]
		public string fields{ get; set; }
	}
}
