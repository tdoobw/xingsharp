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

		public ReceivedFunc ReceivedCB;
		public ErrorFunc ErrorCB;
		public MessageFunc MessageCB;

		public int TimeoutSec;
		public string TRCode;
		public Object InBlock;

		
		public XingQuery()
		{
			TimeoutSec = 10;
		}


	}
}
