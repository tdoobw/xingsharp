using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XingSharp
{
	public class CSPAQ12200Req : TRRequest
	{
		public delegate void OnComplete(TRResult tr_res);
		public OnComplete CompleteCB;




		public CSPAQ12200Req()
		{
		}




		public int Execute(XingSession sess, string acc_no, string acc_pw)
		{
			CSPAQ12200._CSPAQ12200InBlock1 in_block = new CSPAQ12200._CSPAQ12200InBlock1();
			in_block.RecCnt = Encoding.ASCII.GetBytes("00001");
			in_block.MgmtBrnNo = Encoding.ASCII.GetBytes("   ");
			in_block.AcntNo = Encoding.ASCII.GetBytes(acc_no.PadRight(20, ' '));
			in_block.Pwd = Encoding.ASCII.GetBytes(acc_pw.PadRight(8, ' '));
			in_block.BalCreTp = Encoding.ASCII.GetBytes("0");

			XingQuery query = new XingQuery();
			query.TRCode = "CSPAQ12200";
			query.InBlock = in_block;
			query.ReceivedCB = new XingQuery.ReceivedFunc(this.ReceivedFunc);
			query.ErrorCB = new XingQuery.ErrorFunc(this.ErrorFunc);
			query.MessageCB = new XingQuery.MessageFunc(this.MessageFunc);

			int ec = sess.Execute<CSPAQ12200._CSPAQ12200InBlock1>(query, false);
			if (ec < 0) return -1;

			return 0;
		}





		private void ReceivedFunc(XmReceiveData data)
		{
			TRResult tr_res = new TRResult();

			CSPAQ12200._CSPAQ12200OutBlock1 out_block1 = (CSPAQ12200._CSPAQ12200OutBlock1)Marshal.PtrToStructure(data.Data, typeof(CSPAQ12200._CSPAQ12200OutBlock1));
			PushResult<CSPAQ12200._CSPAQ12200OutBlock1>(out_block1, "out_block1", ref tr_res);

			CSPAQ12200._CSPAQ12200OutBlock2 out_block2 = (CSPAQ12200._CSPAQ12200OutBlock2)Marshal.PtrToStructure(IntPtr.Add(data.Data, Marshal.SizeOf(out_block1)), typeof(CSPAQ12200._CSPAQ12200OutBlock2));
			PushResult<CSPAQ12200._CSPAQ12200OutBlock2>(out_block2, "out_block2", ref tr_res);

			if (CompleteCB != null) CompleteCB(tr_res);
		}





		private void ErrorFunc(int etk_req_ec, string err_msg)
		{
		}






		private void MessageFunc(string msg_code, string msg)
		{
			if (msg_code == "00000" || msg_code == "00310") return; //skip success
		}






	}
}
