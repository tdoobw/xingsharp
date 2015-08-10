using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;






namespace XingSharp
{
	public class CSPAT00600Req : TRRequest
	{
		public CSPAT00600Req(EndPoint from_ep)
		: base(from_ep)
		{
		}


		//order_price : if it specified with 0, order with market price
		//trade_cmd : sell / buy
		public int Request(XingSession sess, string trade_cmd, string acc_no, string acc_pw, string shcode, int order_qty, int order_price)
		{
			int ec = 0;
			
			CSPAT00600._CSPAT00600InBlock1 in_block = new CSPAT00600._CSPAT00600InBlock1();
			in_block.AcntNo = Encoding.ASCII.GetBytes(acc_no.PadRight(20, ' '));
			in_block.InptPwd = Encoding.ASCII.GetBytes(acc_pw.PadRight(8, ' '));
			in_block.IsuNo = Encoding.ASCII.GetBytes(("A" + shcode.PadRight(12, ' ')));
			in_block.OrdQty = Encoding.ASCII.GetBytes(order_qty.ToString().PadLeft(16, '0'));
			in_block.OrdPrc = Encoding.ASCII.GetBytes(order_price.ToString().PadLeft(10, '0') + ".00");

			if (trade_cmd == "sell")
			{
				in_block.BnsTpCode = System.Text.Encoding.ASCII.GetBytes("1");
			}
			else
			{
				in_block.BnsTpCode = System.Text.Encoding.ASCII.GetBytes("2");
			}

			//가격을 지정하지 않은경우 시장가로 주문한다
			if (order_price == 0)
			{
				in_block.OrdprcPtnCode = Encoding.ASCII.GetBytes("03");			//시장가
				in_block.OrdPrc = Encoding.ASCII.GetBytes("0000000000.00");		//시장가는 가격을 0으로 설정한다
			}
			else
			{
				in_block.OrdprcPtnCode = Encoding.ASCII.GetBytes("00");			//지정가
			}

			in_block.MgntrnCode = Encoding.ASCII.GetBytes("000");
			in_block.LoanDt = Encoding.ASCII.GetBytes("".PadRight(8, ' '));
			in_block.OrdCndiTpCode = Encoding.ASCII.GetBytes("0");

			XingQuery query = new XingQuery();
			query.TRCode = "CSPAT00600";
			query.InBlock = in_block;
			query.ReceivedCB = new XingQuery.ReceivedFunc(this.ReceivedFunc);
			query.ErrorCB = new XingQuery.ErrorFunc(this.ErrorFunc);
			query.MessageCB = new XingQuery.MessageFunc(this.MessageFunc);

			ec = sess.Execute<CSPAT00600._CSPAT00600InBlock1>(query, false);
			if (ec < 0)
			{
				LogMsg("[CSPAT00600Req::Request] Execute fail. : ec(" + ec + ")");
				return -1;
			}

			return 0;
		}





		private void ReceivedFunc(XmReceiveData data)
		{
			TRResult tr_res = new TRResult();

			CSPAT00600._CSPAT00600OutBlock1 out_block1 = (CSPAT00600._CSPAT00600OutBlock1)Marshal.PtrToStructure(data.Data, typeof(CSPAT00600._CSPAT00600OutBlock1));
			PushResult<CSPAT00600._CSPAT00600OutBlock1>(out_block1, "out_block1", ref tr_res);

			CSPAT00600._CSPAT00600OutBlock2 out_block2 = (CSPAT00600._CSPAT00600OutBlock2)Marshal.PtrToStructure(IntPtr.Add(data.Data, Marshal.SizeOf(out_block1)), typeof(CSPAT00600._CSPAT00600OutBlock2));
			PushResult<CSPAT00600._CSPAT00600OutBlock2>(out_block2, "out_block2", ref tr_res);

			if (this.CompleteCB != null) this.CompleteCB(ep_, tr_res);
		}






		private void ErrorFunc(int etk_req_ec, string err_msg)
		{
			LogMsg("[t0424Req::ErrorFunc] etk_req_ec(" + etk_req_ec + "), err_msg(" + err_msg + ")");
		}






		private void MessageFunc(string msg_code, string msg)
		{
			if (msg_code == "00000" || msg_code == "00310") return; //skip success
			LogMsg("[t0424Req::MessageFunc] msg_code(" + msg_code + "), msg(" + msg + ")");
		}



	}
}
