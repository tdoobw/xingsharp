using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Net;

namespace XingSharp
{
	public class t0424Req : TRRequest
	{
		public t0424Req(EndPoint from_ep)
		: base(from_ep)
		{
		}




		public int Request(XingSession sess, string acc_no, string acc_pw)
		{
			int ec = 0;


			t0424._t0424InBlock in_block = new t0424._t0424InBlock();
			in_block.accno = Encoding.ASCII.GetBytes(acc_no.PadRight(11 + 1, ' '));
			in_block.passwd = Encoding.ASCII.GetBytes(acc_pw.PadRight(8 + 1, ' '));
			in_block.prcgb = Encoding.ASCII.GetBytes("1".PadRight(2, ' '));
			in_block.chegb = Encoding.ASCII.GetBytes("2".PadRight(2, ' '));
			in_block.dangb = Encoding.ASCII.GetBytes("0".PadRight(2, ' '));
			in_block.charge = Encoding.ASCII.GetBytes("1".PadRight(2, ' '));
			in_block.cts_expcode = Encoding.ASCII.GetBytes(" ".PadRight(22 + 1, ' '));

			XingQuery query = new XingQuery();
			query.TRCode = "t0424";
			query.InBlock = in_block;
			query.ReceivedCB = new XingQuery.ReceivedFunc(this.ReceivedFunc);
			query.ErrorCB = new XingQuery.ErrorFunc(this.ErrorFunc);
			query.MessageCB = new XingQuery.MessageFunc(this.MessageFunc);

			ec = sess.Execute<t0424._t0424InBlock>(query, false);
			if (ec < 0) return -1;

			return 0;
		}



		private void ReceivedFunc(XmReceiveData data)
		{
			TRResult tr_res = new TRResult();

			IntPtr cur_ptr = data.Data;

			t0424._t0424OutBlock out_block = (t0424._t0424OutBlock)Marshal.PtrToStructure(cur_ptr, typeof(t0424._t0424OutBlock));
			PushResult<t0424._t0424OutBlock>(out_block, "out_block", ref tr_res);
			cur_ptr = IntPtr.Add(cur_ptr, Marshal.SizeOf(out_block));

			//Extract occur count
			t0424.BlockCount block_count = (t0424.BlockCount)Marshal.PtrToStructure(cur_ptr, typeof(t0424.BlockCount));
			int count = Int32.Parse(Encoding.ASCII.GetString(block_count.count_).TrimStart('0'));
			cur_ptr = IntPtr.Add(cur_ptr, Marshal.SizeOf(block_count));

			//OutBlock1
			for (int i = 0; i < count; i++)
			{
				t0424._t0424OutBlock1 out_block1 = (t0424._t0424OutBlock1)Marshal.PtrToStructure(cur_ptr, typeof(t0424._t0424OutBlock1));
				PushResult<t0424._t0424OutBlock1>(out_block1, "out_block1", ref tr_res);
				cur_ptr = IntPtr.Add(cur_ptr, Marshal.SizeOf(out_block1));
			}

			if (CompleteCB != null) CompleteCB(ep_, tr_res);
		}




		private void ErrorFunc(int etk_req_ec, string err_msg)
		{
			LogMsg("[t0424Req::ErrorFunc] etk_req_ec(" + etk_req_ec + "), err_msg(" + err_msg + ")");
		}



		private void MessageFunc(string msg_code, string msg)
		{
			LogMsg("[t0424Req::MessageFunc] msg_code(" + msg_code + "), msg(" + msg + ")");
		}


	}
}
