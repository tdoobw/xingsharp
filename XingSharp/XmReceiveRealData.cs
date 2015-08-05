using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XingSharp
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	class XmReceiveRealData
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3 + 1)]
		public string TRCode;

		public int KeyLenth;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32 + 1)]
		public string Key;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32 + 1)]
		public string RegKey;

		public int DataLength;
		public IntPtr Data;
	}
}
