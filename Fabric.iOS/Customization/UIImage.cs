using System;
using UIKit;
using CoreGraphics;

namespace Fabric
{
	public static class UIImageMS
	{
		public static UIImage MSButtonBackground (UIColor borderColor, UIColor fillColor, float scale = 0.0f)
		{
			if (scale == 0f)
				scale = (float) UIScreen.MainScreen.Scale;
			const float strokeWidth = 1;
			const float cornerRadius = 4;
			var size = 11 * scale;
			var bounds = new CGRect (0, 0, size, size);

			UIGraphics.BeginImageContextWithOptions (bounds.Size, false, scale);
			borderColor.SetStroke ();
			fillColor.SetFill ();

			var roundedRect = UIBezierPath.FromRoundedRect (bounds, cornerRadius);

			// Clip corners from dirty pixels
			var roundCornerClip = roundedRect.BezierPathByReversingPath ();
			roundCornerClip.AddClip ();
			roundedRect.LineWidth = strokeWidth;
			roundedRect.Fill ();
			roundedRect.Stroke ();

			var bgImage = UIGraphics.GetImageFromCurrentImageContext ();
			UIGraphics.EndImageContext ();
			var r = cornerRadius + strokeWidth;
			return new UIImage (bgImage.CGImage, scale, UIImageOrientation.Up).CreateResizableImage (new UIEdgeInsets (r, r, r, r), UIImageResizingMode.Stretch);
		}
	}
}
