using System;
using UIKit;
using CoreGraphics;
using System.Text;

namespace Fabric.iOS
{
	public class InitialsView : UIView
	{
		UILabel initialsLabel;

		public InitialsView () : this (CGRect.Empty) { }

		public InitialsView (CGRect rect) : base (rect)
		{
			SetupInitialsLabel ();
		}

		void SetupInitialsLabel ()
		{
			initialsLabel = new UILabel (Frame) {
				TextAlignment = UITextAlignment.Center,
				TranslatesAutoresizingMaskIntoConstraints = false,
				Font = UIFontMS.FromStyle (MSFontStyle.XL, MSFontWeight.Regular),
				TextColor = UIColorMS.NeutralWhite,
				ClipsToBounds = true
			};
			AddSubview (initialsLabel);
			SetupConstraints ();
		}

		void SetupConstraints ()
		{
			AddConstraints (NSLayoutConstraint.FromVisualFormat ("H:|-0-[label]-0-|", NSLayoutFormatOptions.AlignAllCenterX, "label", initialsLabel));
			AddConstraints (NSLayoutConstraint.FromVisualFormat ("V:|-0-[label]-0-|", NSLayoutFormatOptions.AlignAllCenterY, "label", initialsLabel));
		}

		public void SetInitialsFromTitle (string title)
		{
			var s = new StringBuilder (2);
			bool getNext = true;

			foreach (var c in title) {
				if (getNext) {
					s.Append (Char.ToUpper (c));
					getNext = false;
					if (s.Length == 2)
						break;
				} else if (c == ' ')
					getNext = true;
			}
			initialsLabel.Text = s.ToString ();
			BackgroundColor = UIColorMS.HashColor (title);
		}
	}
}
