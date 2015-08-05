using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingSharp
{
	public class XingQuery
	{
		public delegate void ReceivedFunc(XmReceiveData data);
		public delegate void ErrorFunc(int etk_req_ec, string err_msg);
		public delegate void MessageFunc(string msg_code, string msg);

		public ReceivedFunc ReceivedCB { get; set; }
		public ErrorFunc ErrorCB { get; set; }
		public MessageFunc MessageCB { get; set; }

		public int TimeoutSec { get; set; }
		public string TRCode { get; set; }
		public Object InBlock { get; set; }

		private HtsApi hts_api_ = null;






		public HtsQuery(HtsApi hts_api)
		{
			TimeoutSec = 10;
			hts_api_ = hts_api;

			TRCode = "";
			InBlock = null;

			ReceivedCB = null;
			ErrorCB = null;
			MessageCB = null;
		}





		public int Request<INBLOCK_T>(bool continue_req = false)
		{
			if (TRCode.Length == 0 || InBlock == null) return -1;
			if (ReceivedCB == null || ErrorCB == null) return -2;

			return hts_api_.Request<INBLOCK_T>(this, continue_req);
		}
	}
}
