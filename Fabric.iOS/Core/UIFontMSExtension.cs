using System;
using UIKit;

namespace Fabric
{
	public static partial class MSFontConstants
	{
		public static nfloat FontSize (MSFontStyle style)
		{
			switch (style) {
			case MSFontStyle.SU:
				return 42;
			case MSFontStyle.XXL:
				return 28;
			case MSFontStyle.XL:
				return 21;
			case MSFontStyle.L:
				return 17;
			case MSFontStyle.MPlus:
				return 15;
			case MSFontStyle.M:
				return 14;
			case MSFontStyle.SPlus:
				return 13;
			case MSFontStyle.S:
				return 12;
			case MSFontStyle.XS:
				return 11;
			case MSFontStyle.MI:
				return 10;
			default:
				throw new ArgumentOutOfRangeException ();
			}
		}

		internal static UIFontWeight FontWeight (MSFontWeight weight)
		{
			switch (weight) {
			case MSFontWeight.Light:
				return UIFontWeight.Thin;
			case MSFontWeight.SemiLight:
				return UIFontWeight.Light;
			case MSFontWeight.Regular:
				return UIFontWeight.Regular;
			case MSFontWeight.Semibold:
				return UIFontWeight.Semibold;
			default:
				throw new ArgumentOutOfRangeException ();
			}
		}
	}

	public static class UIFontMS
	{
		public static UIFont FromStyle (MSFontStyle style, MSFontWeight weight)
		{
			if (UIDevice.CurrentDevice.CheckSystemVersion (8, 2))
				return UIFont.SystemFontOfSize (MSFontConstants.FontSize (style), MSFontConstants.FontWeight (weight));
			else
				return UIFont.SystemFontOfSize (MSFontConstants.FontSize (style));
		}
	}
}
