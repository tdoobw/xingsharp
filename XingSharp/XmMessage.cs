using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;




namespace XingSharp
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	public class XmMessage
	{
		public int request_id_;
		public int system_error_;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
		public string msg_code_;

		public int msg_data_len_;
		public IntPtr msg_data_ = new IntPtr();
	};
}
