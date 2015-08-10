using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XingSharp
{
	public class CSPAT00600
	{

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
		public struct _CSPAT00600InBlock1
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20 + 0)]
			public byte[] AcntNo; //StartPos(0)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 0)]
			public byte[] InptPwd; //StartPos(20)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 0)]
			public byte[] IsuNo; //StartPos(28)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] OrdQty; //StartPos(40)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 13 + 0)]
			public byte[] OrdPrc; //StartPos(56)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 0)]
			public byte[] BnsTpCode; //StartPos(69)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2 + 0)]
			public byte[] OrdprcPtnCode; //StartPos(70)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 + 0)]
			public byte[] MgntrnCode; //StartPos(72)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 0)]
			public byte[] LoanDt; //StartPos(75)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 0)]
			public byte[] OrdCndiTpCode; //StartPos(83)

		};

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
		public struct _CSPAT00600OutBlock1
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5 + 0)]
			public byte[] RecCnt; //StartPos(0)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20 + 0)]
			public byte[] AcntNo; //StartPos(5)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 0)]
			public byte[] InptPwd; //StartPos(25)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 0)]
			public byte[] IsuNo; //StartPos(33)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] OrdQty; //StartPos(45)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 13 + 0)]
			public byte[] OrdPrc; //StartPos(61)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 0)]
			public byte[] BnsTpCode; //StartPos(74)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2 + 0)]
			public byte[] OrdprcPtnCode; //StartPos(75)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2 + 0)]
			public byte[] PrgmOrdprcPtnCode; //StartPos(77)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 0)]
			public byte[] StslAbleYn; //StartPos(79)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 0)]
			public byte[] StslOrdprcTpCode; //StartPos(80)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2 + 0)]
			public byte[] CommdaCode; //StartPos(81)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 + 0)]
			public byte[] MgntrnCode; //StartPos(83)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 0)]
			public byte[] LoanDt; //StartPos(86)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 + 0)]
			public byte[] MbrNo; //StartPos(94)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 0)]
			public byte[] OrdCndiTpCode; //StartPos(97)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 0)]
			public byte[] StrtgCode; //StartPos(98)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20 + 0)]
			public byte[] GrpId; //StartPos(104)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 0)]
			public byte[] OrdSeqNo; //StartPos(124)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 0)]
			public byte[] PtflNo; //StartPos(134)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 0)]
			public byte[] BskNo; //StartPos(144)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 0)]
			public byte[] TrchNo; //StartPos(154)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 0)]
			public byte[] ItemNo; //StartPos(164)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 0)]
			public byte[] OpDrtnNo; //StartPos(174)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 0)]
			public byte[] LpYn; //StartPos(186)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 0)]
			public byte[] CvrgTpCode; //StartPos(187)

		};

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
		public struct _CSPAT00600OutBlock2
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5 + 0)]
			public byte[] RecCnt; //StartPos(0)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 0)]
			public byte[] OrdNo; //StartPos(5)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9 + 0)]
			public byte[] OrdTime; //StartPos(15)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2 + 0)]
			public byte[] OrdMktCode; //StartPos(24)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2 + 0)]
			public byte[] OrdPtnCode; //StartPos(26)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9 + 0)]
			public byte[] ShtnIsuNo; //StartPos(28)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9 + 0)]
			public byte[] MgempNo; //StartPos(37)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] OrdAmt; //StartPos(46)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 0)]
			public byte[] SpareOrdNo; //StartPos(62)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 0)]
			public byte[] CvrgSeqno; //StartPos(72)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 0)]
			public byte[] RsvOrdNo; //StartPos(82)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] SpotOrdQty; //StartPos(92)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] RuseOrdQty; //StartPos(108)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] MnyOrdAmt; //StartPos(124)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] SubstOrdAmt; //StartPos(140)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] RuseOrdAmt; //StartPos(156)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40 + 0)]
			public byte[] AcntNm; //StartPos(172)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40 + 0)]
			public byte[] IsuNm; //StartPos(212)

		};


	}
}
