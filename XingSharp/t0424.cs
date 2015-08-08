using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XingSharp
{
	public class t0424
	{

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
		public struct _t0424InBlock
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11 + 1)]
			public byte[] accno; //string(11)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] passwd; //string(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 1)]
			public byte[] prcgb; //string(1)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 1)]
			public byte[] chegb; //string(1)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 1)]
			public byte[] dangb; //string(1)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 1)]
			public byte[] charge; //string(1)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 22 + 1)]
			public byte[] cts_expcode; //string(22)

		};

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
		public struct _t0424OutBlock
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] sunamt; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] dtsunik; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] mamt; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] sunamt1; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 22 + 1)]
			public byte[] cts_expcode; //string(22)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] tappamt; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] tdtsunik; //long(18)

		};

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
		public struct _t0424OutBlock1
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] expcode; //string(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 1)]
			public byte[] jangb; //string(10)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] janqty; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] mdposqt; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] pamt; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] mamt; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] sinamt; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] lastdt; //string(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] msat; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] mpms; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] mdat; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] mpmd; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] jsat; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] jpms; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] jdat; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] jpmd; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 1)]
			public byte[] sysprocseq; //long(10)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] loandt; //string(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20 + 1)]
			public byte[] hname; //string(20)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 1)]
			public byte[] marketgb; //string(1)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 1)]
			public byte[] jonggb; //string(1)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 1)]
			public byte[] janrt; //float(10.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] price; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] appamt; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] dtsunik; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 1)]
			public byte[] sunikrt; //float(10.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 1)]
			public byte[] fee; //long(10)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 1)]
			public byte[] tax; //long(10)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 1)]
			public byte[] sininter; //long(10)

		};



		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
		public struct BlockCount
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
			public byte[] count_;
		};

	}
}
