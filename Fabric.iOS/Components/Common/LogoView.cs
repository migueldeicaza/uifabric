using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Fabric.iOS
{
	public class LogoView : UIView 
	{
		InitialsView initialsView;
		UIImageView imageView;

		public LogoView (CGRect frame) : base (frame)
		{
			SetupSubviews ();
		}

		public LogoView (NSCoder aDecoder) : base (aDecoder)
		{
			SetupSubviews ();
		}

		void SetupSubviews ()
		{
			imageView = new UIImageView (CGRect.Empty) {
				ContentMode = UIViewContentMode.ScaleAspectFit,
				ClipsToBounds = true
			};
			initialsView = new InitialsView () {
				ClipsToBounds = true
			};
			SetupSubview (imageView);
			SetupSubview (initialsView);
		}

		void SetupSubview (UIView subview)
		{
			AddSubview (subview);
			subview.Hidden = true;
		}

		public override void LayoutSubviews ()
		{
			imageView.Frame = Bounds;
			initialsView.Frame = Bounds;
		}

		public void UpdateWithTitle (string title)
		{
			initialsView.SetInitialsFromTitle (title);
			initialsView.Hidden = false;
			imageView.Hidden = true;
		}

		public void UpdateWithImage (UIImage image)
		{
			imageView.Image = image;
			imageView.Hidden = false;
			initialsView.Hidden = true;
		}
	}
}
