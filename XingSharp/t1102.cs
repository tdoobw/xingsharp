using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XingSharp
{
	public class t1102
	{

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
		public struct _t1102InBlock
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 0)]
			public byte[] shcode; //string(6)

		};

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
		public struct _t1102OutBlock
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20 + 1)]
			public byte[] hname; //string(20)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] price; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 1)]
			public byte[] sign; //string(1)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] change; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] diff; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] volume; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] recprice; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] avg; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] uplmtprice; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] dnlmtprice; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] jnilvolume; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] volumediff; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] open; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] opentime; //string(6)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] high; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] hightime; //string(6)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] low; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] lowtime; //string(6)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] high52w; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] high52wdate; //string(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] low52w; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] low52wdate; //string(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] exhratio; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] per; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] pbrx; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] listing; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] jkrate; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5 + 1)]
			public byte[] memedan; //string(5)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 + 1)]
			public byte[] offernocd1; //string(3)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 + 1)]
			public byte[] bidnocd1; //string(3)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] offerno1; //string(6)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] bidno1; //string(6)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] dvol1; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] svol1; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] dcha1; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] scha1; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] ddiff1; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] sdiff1; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 + 1)]
			public byte[] offernocd2; //string(3)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 + 1)]
			public byte[] bidnocd2; //string(3)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] offerno2; //string(6)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] bidno2; //string(6)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] dvol2; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] svol2; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] dcha2; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] scha2; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] ddiff2; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] sdiff2; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 + 1)]
			public byte[] offernocd3; //string(3)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 + 1)]
			public byte[] bidnocd3; //string(3)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] offerno3; //string(6)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] bidno3; //string(6)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] dvol3; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] svol3; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] dcha3; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] scha3; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] ddiff3; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] sdiff3; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 + 1)]
			public byte[] offernocd4; //string(3)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 + 1)]
			public byte[] bidnocd4; //string(3)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] offerno4; //string(6)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] bidno4; //string(6)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] dvol4; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] svol4; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] dcha4; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] scha4; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] ddiff4; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] sdiff4; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 + 1)]
			public byte[] offernocd5; //string(3)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 + 1)]
			public byte[] bidnocd5; //string(3)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] offerno5; //string(6)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] bidno5; //string(6)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] dvol5; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] svol5; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] dcha5; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] scha5; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] ddiff5; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] sdiff5; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] fwdvl; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] ftradmdcha; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] ftradmddiff; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] fwsvl; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] ftradmscha; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] ftradmsdiff; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] vol; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] shcode; //string(6)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] value; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] jvolume; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] highyear; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] highyeardate; //string(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] lowyear; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] lowyeardate; //string(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] target; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] capital; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] abscnt; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] parprice; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2 + 1)]
			public byte[] gsmm; //string(2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] subprice; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] total; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] listdate; //string(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 1)]
			public byte[] name; //string(10)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] bfsales; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] bfoperatingincome; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] bfordinaryincome; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] bfnetincome; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 13 + 1)]
			public byte[] bfeps; //float(13.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 1)]
			public byte[] name2; //string(10)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] bfsales2; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] bfoperatingincome2; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] bfordinaryincome2; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] bfnetincome2; //long(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 13 + 1)]
			public byte[] bfeps2; //float(13.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7 + 1)]
			public byte[] salert; //float(7.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7 + 1)]
			public byte[] opert; //float(7.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7 + 1)]
			public byte[] ordrt; //float(7.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7 + 1)]
			public byte[] netrt; //float(7.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7 + 1)]
			public byte[] epsrt; //float(7.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 1)]
			public byte[] info1; //string(10)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 1)]
			public byte[] info2; //string(10)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 1)]
			public byte[] info3; //string(10)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12 + 1)]
			public byte[] info4; //string(12)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10 + 1)]
			public byte[] janginfo; //string(10)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6 + 1)]
			public byte[] t_per; //float(6.2)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 + 1)]
			public byte[] tonghwa; //string(3)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] dval1; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] sval1; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] dval2; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] sval2; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] dval3; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] sval3; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] dval4; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] sval4; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] dval5; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] sval5; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] davg1; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] savg1; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] davg2; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] savg2; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] davg3; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] savg3; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] davg4; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] savg4; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] davg5; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] savg5; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] ftradmdval; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18 + 1)]
			public byte[] ftradmsval; //long(18)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] ftradmdavg; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] ftradmsavg; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] info5; //string(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 1)]
			public byte[] spac_gubun; //string(1)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] issueprice; //long(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1 + 1)]
			public byte[] alloc_gubun; //string(1)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] alloc_text; //string(8)

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 + 1)]
			public byte[] shterm_text; //string(8)

		};
	}
}
