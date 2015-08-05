using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingSharp
{
	using SS_MAP = Dictionary<string, string>;

	public class TRResult
	{
		public int error_code_ { get; set; }
		public MultiMap<string, SS_MAP> map_ = new MultiMap<string, SS_MAP>();
	}
}
