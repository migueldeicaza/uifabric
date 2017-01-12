using System;
using UIKit;
using CoreGraphics;

namespace Fabric.iOS
{
	public static class UILabelExtensions 
	{
		public static void MSLabel (this UILabel self, MSFontStyle style = MSFontStyle.L, UIColor textColor = null)
		{
			if (textColor == null)
				textColor = UIColorMS.NeutralPrimary;
			self.Font = UIFontMS.FromStyle (style, MSFontConstants.PreferredFontWeight (style));
			self.TextColor = textColor;
		}

		public static void MSLabel (this UILabel self, MSFontWeight fontWeight, MSFontStyle style = MSFontStyle.L, UIColor textColor = null)
		{
			if (textColor == null)
				textColor = UIColorMS.NeutralPrimary;
			self.Font = UIFontMS.FromStyle (style, fontWeight);
			self.TextColor = textColor;
		}
	}
}
