using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;







namespace XingSharp
{
    public class XingSession
    {
		[DllImport("C:\\ETRADE\\xingAPI\\xingAPI.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		public static extern bool ETK_Connect(IntPtr hWnd, string pszSvr, int nPort, int nStartMsgID, int nTimeOut, int nSendMaxPacketSize);

		[DllImport("C:\\ETRADE\\xingAPI\\xingAPI.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		public static extern int ETK_GetLastError();

		[DllImport("C:\\ETRADE\\xingAPI\\xingAPI.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		public static extern bool ETK_Login(IntPtr hWnd, string pszID, string pszPwd, string pszCertPwd, int nType, [In, MarshalAs(UnmanagedType.Bool)] bool bShowCertErrDlg);

		[DllImport("C:\\ETRADE\\xingAPI\\xingAPI.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		public static extern int ETK_Request(IntPtr hWnd, string pszTrCode, IntPtr lpData, int nDataSize, [In, MarshalAs(UnmanagedType.Bool)] bool bNext, string pszContinueKey, int nTimeOut);

		[DllImport("C:\\ETRADE\\xingAPI\\xingAPI.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		public static extern void ETK_ReleaseRequestData(int nRequestID);

		[DllImport("C:\\ETRADE\\xingAPI\\xingAPI.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		public static extern void ETK_ReleaseMessageData(IntPtr lparam);

		[DllImport("C:\\ETRADE\\xingAPI\\xingAPI.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		public static extern int ETK_GetAccountListCount();

		[DllImport("C:\\ETRADE\\xingAPI\\xingAPI.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		public static extern bool ETK_GetAccountList(int nIndex, IntPtr pszAcc, int nAccSize);

		[DllImport("C:\\ETRADE\\xingAPI\\xingAPI.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		public static extern int ETK_Disconnect();


		public enum XING_MSG
		{
			WM_USER = 0x400,

			XM_DISCONNECT			= 1 + WM_USER,
			XM_RECEIVE_DATA			= 3 + WM_USER,
			XM_RECEIVE_REAL_DATA	= 4 + WM_USER,
			XM_LOGIN				= 5 + WM_USER,
			XM_LOGOUT				= 6 + WM_USER,
			XM_TIMEOUT				= 7 + WM_USER,

			BEGIN					= WM_USER,
			END						= 975 + WM_USER,
		};


		public enum RECVDATA_KIND
		{
			DATA					= 1,
			MESSAGE					= 2,
			ERROR					= 3,
			RELEASE					= 4,
		}

		public delegate void LoginCallback(bool is_success);
		public delegate void LogoutCallback();
		public delegate void RecvRealPacketCallback(XmReceiveRealData packet);
		public delegate void DisconnectCallback();

		public LoginCallback LoginCB;
		public LogoutCallback LogoutCB;
		public RecvRealPacketCallback ReceiveRealCB;
		public DisconnectCallback DisconnectCB;

		private XingQuery query_ { get; set; }



		public void WndProc(ref Message m)
		{
			if (m.Msg < (int)XING_MSG.BEGIN || m.Msg > (int)XING_MSG.END) return;

			switch ((XING_MSG)m.Msg)
			{
				case XING_MSG.XM_LOGIN:				XMLogin(ref m);			break;
				case XING_MSG.XM_RECEIVE_DATA:		XMRecvData(ref m);		break;
				case XING_MSG.XM_RECEIVE_REAL_DATA: XMRecvRealData(ref m);	break;
				case XING_MSG.XM_DISCONNECT:		XMDisconnect(ref m);	break;
			};
		}





		private void XMLogin(ref Message m)
		{
			string w_param_str = Marshal.PtrToStringAnsi(m.WParam);
			if (LoginCB != null)
			{
				if (w_param_str == "0000") LoginCB(true);
				else LoginCB(false);
			}
		}






		private void XMRecvData(ref Message m)
		{
			switch ((RECVDATA_KIND)m.WParam)
			{
				case RECVDATA_KIND.DATA:	RecvData(ref m);	break;
				case RECVDATA_KIND.MESSAGE: RecvMessage(ref m); break;
				case RECVDATA_KIND.ERROR:	RecvError(ref m);	break;
				case RECVDATA_KIND.RELEASE: RecvRelease(ref m); break;
			}
		}






		private void XMRecvRealData(ref Message m)
		{
			XmReceiveRealData data = new XmReceiveRealData();
			Marshal.PtrToStructure(m.LParam, data);

			if (ReceiveRealCB != null) ReceiveRealCB(data);
		}





		private void XMDisconnect(ref Message m)
		{
			if (DisconnectCB != null)
			{
				DisconnectCB();
			}
		}





		private void RecvData(ref Message m)
		{
			XmReceiveData hts_recv_pkt = new XmReceiveData();
			Marshal.PtrToStructure(m.LParam, hts_recv_pkt);

			if (query_ != null && hts_recv_pkt.DataLength > 0)
			{
				if (query_.ReceivedCB != null) query_.ReceivedCB(hts_recv_pkt);
			}
		}






		private void RecvMessage(ref Message m)
		{
			XmMessage xm_msg = new XmMessage();
			Marshal.PtrToStructure(m.LParam, xm_msg);

			string msg_code = xm_msg.msg_code_.Trim();
			string msg = Marshal.PtrToStringAnsi(xm_msg.msg_data_, xm_msg.msg_data_len_).Trim();

			if (query_ != null)
			{
				if (query_.MessageCB != null) query_.MessageCB(msg_code, msg);
			}

			ETK_ReleaseMessageData(m.LParam);
		}





		private void RecvError(ref Message m)
		{
			XmMessage xm_msg = new XmMessage();
			Marshal.PtrToStructure(m.LParam, xm_msg);

			ETK_ReleaseMessageData(m.LParam);
		}






		private void RecvRelease(ref Message m)
		{
			int RequestID = (int)m.LParam;
			ETK_ReleaseRequestData(RequestID);
		}

    }
}
