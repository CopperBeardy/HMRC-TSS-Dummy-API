using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeTradeSupportService.Models.SupplementaryDeclaration
{
	public class SDRequest : SupplementaryDeclaration
	{
		[JsonProperty("op_type")]
		public string op_type { get; set; } = "update";
	}
}
