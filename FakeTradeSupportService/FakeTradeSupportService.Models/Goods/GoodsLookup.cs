using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FakeTradeSupportService.Models.Goods
{
	public class GoodsLookup
	{
		[JsonProperty("sfd_number")]
		public virtual string sfd_number { get; set; }

		[JsonProperty("sup_dec_number”")]
		public virtual string sup_dec_number { get; set; }
	}
	public class LookupItem
		{
			[JsonProperty("reference")]
			public string reference { get; set; }

			[JsonProperty("goods_description")]
			public string goods_description { get; set; }
			[JsonProperty("package_marks")]
			public string package_marks { get; set; }
		}
		public class sfdlookup
		{
			[JsonProperty("sfd_number")]

			public virtual string sfd_number { get; set; }
			[JsonProperty("goods")]
			public LookupItem[] Goods { get; set; }
		}

		public class suplookup
		{
		[JsonProperty("sup_dec_number”")]
		public virtual string sup_dec_number { get; set; }
		[JsonProperty("goods")]
		public LookupItem[] Goods { get; set; }
	}
}
