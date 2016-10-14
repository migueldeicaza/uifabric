using System;
namespace Fabric
{
	public enum MSFontStyle
	{
		SU, XXL, XL, L, MPlus, M, SPlus, S, XS, MI
	}

	public enum MSFontWeight
	{
		Light, SemiLight, Regular, Semibold
	}

	partial class MSFontConstants
	{
		public static MSFontWeight PreferredFontWeight (MSFontStyle style)
		{
			switch (style) {
			case MSFontStyle.SU:
			case MSFontStyle.XXL:
			case MSFontStyle.XL:
				return MSFontWeight.Light;
			case MSFontStyle.L:
				return MSFontWeight.SemiLight;
			case MSFontStyle.MPlus:
			case MSFontStyle.M:
			case MSFontStyle.SPlus:
			case MSFontStyle.S:
			case MSFontStyle.XS:
				return MSFontWeight.Regular;
			case MSFontStyle.MI:
				return MSFontWeight.Semibold;
			default:
				throw new ArgumentOutOfRangeException ();
			}
		}
	}
}
