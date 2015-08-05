using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XingSharp
{
	public class CSPAQ12200
	{
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
		public struct _CSPAQ12200InBlock1
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5 + 0)]
			public byte[] RecCnt; //StartPos(0)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 + 0)]
			public byte[] MgmtBrnNo; //StartPos(5)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20 + 0)]
			public byte[] AcntNo; //StartPos(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 0)]
			public byte[] Pwd; //StartPos(28)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 0)]
			public byte[] BalCreTp; //StartPos(36)

		};

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
		public struct _CSPAQ12200OutBlock1
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5 + 0)]
			public byte[] RecCnt; //StartPos(0)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 + 0)]
			public byte[] MgmtBrnNo; //StartPos(5)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20 + 0)]
			public byte[] AcntNo; //StartPos(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 0)]
			public byte[] Pwd; //StartPos(28)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 0)]
			public byte[] BalCreTp; //StartPos(36)

		};

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
		public struct _CSPAQ12200OutBlock2
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5 + 0)]
			public byte[] RecCnt; //StartPos(0)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40 + 0)]
			public byte[] BrnNm; //StartPos(5)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40 + 0)]
			public byte[] AcntNm; //StartPos(45)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] MnyOrdAbleAmt; //StartPos(85)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] MnyoutAbleAmt; //StartPos(101)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] SeOrdAbleAmt; //StartPos(117)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] KdqOrdAbleAmt; //StartPos(133)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] BalEvalAmt; //StartPos(149)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] RcvblAmt; //StartPos(165)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] DpsastTotamt; //StartPos(181)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 0)]
			public byte[] PnlRat; //StartPos(197)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20 + 0)]
			public byte[] InvstOrgAmt; //StartPos(215)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] InvstPlAmt; //StartPos(235)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] CrdtPldgOrdAmt; //StartPos(251)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] Dps; //StartPos(267)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] SubstAmt; //StartPos(283)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] D1Dps; //StartPos(299)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] D2Dps; //StartPos(315)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] MnyrclAmt; //StartPos(331)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] MgnMny; //StartPos(347)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] MgnSubst; //StartPos(363)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] ChckAmt; //StartPos(379)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] SubstOrdAbleAmt; //StartPos(395)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] MgnRat100pctOrdAbleAmt; //StartPos(411)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] MgnRat35ordAbleAmt; //StartPos(427)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] MgnRat50ordAbleAmt; //StartPos(443)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] PrdaySellAdjstAmt; //StartPos(459)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] PrdayBuyAdjstAmt; //StartPos(475)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] CrdaySellAdjstAmt; //StartPos(491)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] CrdayBuyAdjstAmt; //StartPos(507)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] D1ovdRepayRqrdAmt; //StartPos(523)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] D2ovdRepayRqrdAmt; //StartPos(539)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] D1PrsmptWthdwAbleAmt; //StartPos(555)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] D2PrsmptWthdwAbleAmt; //StartPos(571)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] DpspdgLoanAmt; //StartPos(587)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] Imreq; //StartPos(603)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] MloanAmt; //StartPos(619)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9 + 0)]
			public byte[] ChgAfPldgRat; //StartPos(635)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] OrgPldgAmt; //StartPos(644)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] SubPldgAmt; //StartPos(660)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] RqrdPldgAmt; //StartPos(676)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] OrgPdlckAmt; //StartPos(692)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] PdlckAmt; //StartPos(708)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] AddPldgMny; //StartPos(724)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] D1OrdAbleAmt; //StartPos(740)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] CrdtIntdltAmt; //StartPos(756)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] EtclndAmt; //StartPos(772)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] NtdayPrsmptCvrgAmt; //StartPos(788)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] OrgPldgSumAmt; //StartPos(804)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] CrdtOrdAbleAmt; //StartPos(820)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] SubPldgSumAmt; //StartPos(836)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] CrdtPldgAmtMny; //StartPos(852)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] CrdtPldgSubstAmt; //StartPos(868)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] AddCrdtPldgMny; //StartPos(884)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] CrdtPldgRuseAmt; //StartPos(900)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] AddCrdtPldgSubst; //StartPos(916)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] CslLoanAmtdt1; //StartPos(932)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 + 0)]
			public byte[] DpslRestrcAmt; //StartPos(948)

		};
	}
}
