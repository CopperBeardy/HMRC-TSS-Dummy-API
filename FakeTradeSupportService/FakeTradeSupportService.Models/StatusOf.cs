using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeTradeSupportService.Models
{
	public class StatusOf
	{
		[JsonProperty("status")]
		public string status { get; set; }
	}
}
