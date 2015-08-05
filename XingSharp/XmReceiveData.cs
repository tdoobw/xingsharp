using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XingSharp
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	class XmReceiveData
	{
		public int RequestID;
		public int DataLength;
		public int TotalDataBufferSize;
		public int ElapsedTime;
		public int DataMode;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10 + 1)]
		public string TRCode;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
		public string Continue;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 18 + 1)]
		public string ContinueKey;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30 + 1)]
		public string UserData;	//not used

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		public string BlockName;

		public IntPtr Data;
	}
}
