using System;
using UIKit;

namespace Fabric
{
	public static class UIButtonExtensions
	{
		public static void MSStandardButton (this UIButton self, UIColor mainColor = null, UIColor disabledColor = null)
		{
			if (mainColor == null)
				mainColor = UIColorMS.ThemePrimary;
			if (disabledColor == null)
				disabledColor = UIColorMS.NeutralTertiaryAlt;
			self.SetBackgroundImage (UIImageMS.MSButtonBackground (mainColor, UIColor.Clear), self.State);
			self.SetBackgroundImage (UIImageMS.MSButtonBackground (mainColor, mainColor), UIControlState.Highlighted);
			self.SetBackgroundImage (UIImageMS.MSButtonBackground (mainColor, mainColor), UIControlState.Selected);
			self.SetBackgroundImage (UIImageMS.MSButtonBackground (disabledColor, disabledColor.ColorWithAlpha (0.1f)), UIControlState.Disabled);

			self.SetTitleColor (mainColor, self.State);
			self.SetTitleColor (UIColorMS.NeutralWhite, UIControlState.Highlighted);
			self.SetTitleColor (UIColorMS.NeutralWhite, UIControlState.Selected);
			self.SetTitleColor (disabledColor, UIControlState.Disabled);
		}

		public static void MSPrimaryButton (this UIButton self, UIColor mainColor = null, UIColor selectedColor = null, UIColor disabledColor = null)
		{
			if (mainColor == null)
				mainColor = UIColorMS.ThemePrimary;
			if (selectedColor == null)
				selectedColor = UIColorMS.ThemeDark;
			if (disabledColor == null)
				disabledColor = UIColorMS.NeutralTertiaryAlt;
			self.SetBackgroundImage (UIImageMS.MSButtonBackground (mainColor, mainColor), self.State);
			self.SetBackgroundImage (UIImageMS.MSButtonBackground (selectedColor, selectedColor), UIControlState.Highlighted);
			self.SetBackgroundImage (UIImageMS.MSButtonBackground (selectedColor, selectedColor), UIControlState.Selected);
			self.SetBackgroundImage (UIImageMS.MSButtonBackground (disabledColor, disabledColor), UIControlState.Disabled);

			self.SetTitleColor (UIColorMS.NeutralWhite, self.State);
			self.SetTitleColor (UIColorMS.NeutralWhite, UIControlState.Highlighted);
			self.SetTitleColor (UIColorMS.NeutralWhite, UIControlState.Selected);
			self.SetTitleColor (UIColorMS.NeutralWhite, UIControlState.Disabled);
		}
	}
}
