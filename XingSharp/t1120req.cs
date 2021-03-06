﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Net;






namespace XingSharp
{
	public class t1102Req : TRRequest
	{
		public t1102Req(EndPoint from_ep)
		: base(from_ep)
		{
			
		}



		public int Request(XingSession sess, string shcode)
		{
			int ec = 0;


			t1102._t1102InBlock in_block = new t1102._t1102InBlock();
			in_block.shcode = Encoding.ASCII.GetBytes(shcode);

			XingQuery query = new XingQuery();
			query.TRCode = "t1102";
			query.InBlock = in_block;
			query.ReceivedCB = new XingQuery.ReceivedFunc(this.ReceivedFunc);
			query.ErrorCB = new XingQuery.ErrorFunc(this.ErrorFunc);

			ec = sess.Execute<t1102._t1102InBlock>(query, false);
			if (ec < 0)
			{
				LogMsg("[t1102Req::Request] Execute fail. : ec(" + ec + ")");
				return -1;
			}

			return 0;
		}



		private void ReceivedFunc(XmReceiveData data)
		{
			switch (data.BlockName)
			{
				case "t1102OutBlock": t1102OutBlock(data); break;
			}
		}



		private void t1102OutBlock(XmReceiveData data)
		{
			TRResult tr_res = new TRResult();

			t1102._t1102OutBlock out_block = (t1102._t1102OutBlock)Marshal.PtrToStructure(data.Data, typeof(t1102._t1102OutBlock));
			PushResult<t1102._t1102OutBlock>(out_block, "out_block", ref tr_res);

			if (CompleteCB != null) CompleteCB(ep_, tr_res);
		}




		private void ErrorFunc(int etk_req_ec, string err_msg)
		{
			LogMsg("[t1102Req::ErrorFunc] etk_req_ec(" + etk_req_ec + "), err_msg(" + err_msg + ")");
		}





		private void MessageFunc(string msg_code, string msg)
		{
			LogMsg("[t1102Req::MessageFunc] msg_code(" + msg_code + "), msg(" + msg + ")");
		}
	}
}
