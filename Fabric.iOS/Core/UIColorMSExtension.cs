using System;
using UIKit;

namespace Fabric
{
	public static class UIColorMS
	{
		// MARK: Theme Colors
		public static UIColor ThemeDarker => new UIColor (red: 0.000f, green: 0.271f, blue: 0.471f, alpha: 1); // #004578

		public static UIColor ThemeDark => new UIColor (red: 0.000f, green: 0.353f, blue: 0.620f, alpha: 1); // #005a9e

		public static UIColor ThemeDarkAlt => new UIColor (red: 0.063f, green: 0.431f, blue: 0.745f, alpha: 1); // #106ebe

		public static UIColor ThemePrimary => new UIColor (red: 0.000f, green: 0.471f, blue: 0.843f, alpha: 1); // #0078d7

		public static UIColor ThemeSecondary => new UIColor (red: 0.169f, green: 0.533f, blue: 0.847f, alpha: 1); // #2b88d8

		public static UIColor ThemeTertiary => new UIColor (red: 0.443f, green: 0.686f, blue: 0.898f, alpha: 1); // #71afe5

		public static UIColor ThemeLight => new UIColor (red: 0.780f, green: 0.878f, blue: 0.957f, alpha: 1); // #c7e0f4

		public static UIColor ThemeLighter => new UIColor (red: 0.871f, green: 0.925f, blue: 0.976f, alpha: 1); // #deecf9

		public static UIColor ThemeLighterAlt => new UIColor (red: 0.937f, green: 0.965f, blue: 0.988f, alpha: 1); // #eff6fc


		// MARK: Neutral Colors
		public static UIColor NeutralBlack => new UIColor (white: 0.000f, alpha: 1); // #000000

		public static UIColor NeutralDark => new UIColor (white: 0.129f, alpha: 1); // #212121

		public static UIColor NeutralPrimary => new UIColor (white: 0.200f, alpha: 1); // #333333

		public static UIColor NeutralSecondary => new UIColor (white: 0.400f, alpha: 1); // #666666

		public static UIColor NeutralSecondaryAlt => new UIColor (white: 0.463f, alpha: 1); // #767676

		public static UIColor NeutralTertiary => new UIColor (white: 0.651f, alpha: 1); // #a6a6a6

		public static UIColor NeutralTertiaryAlt => new UIColor (white: 0.784f, alpha: 1); // #c8c8c8

		public static UIColor NeutralLight => new UIColor (white: 0.918f, alpha: 1); // #eaeaea

		public static UIColor NeutralLighter => new UIColor (white: 0.957f, alpha: 1); // #f4f4f4

		public static UIColor NeutralLighterAlt => new UIColor (white: 0.973f, alpha: 1); // #f8f8f8

		public static UIColor NeutralWhite => new UIColor (white: 1.000f, alpha: 1); // #ffffff


		// MARK: Accent Colors
		public static UIColor AccentYellow => new UIColor (red: 1.000f, green: 0.725f, blue: 0.000f, alpha: 1); // #ffb900

		public static UIColor AccentYellowLight => new UIColor (red: 1.000f, green: 0.945f, blue: 0.000f, alpha: 1); // #fff100

		public static UIColor AccentOrange => new UIColor (red: 0.847f, green: 0.231f, blue: 0.004f, alpha: 1); // #d83b01

		public static UIColor AccentOrangeLight => new UIColor (red: 1.000f, green: 0.549f, blue: 0.000f, alpha: 1); // #ff8c00

		public static UIColor AccentRedDark => new UIColor (red: 0.659f, green: 0.000f, blue: 0.000f, alpha: 1); // #a80000

		public static UIColor AccentRed => new UIColor (red: 0.910f, green: 0.067f, blue: 0.137f, alpha: 1); // #e81123

		public static UIColor AccentMagentaDark => new UIColor (red: 0.361f, green: 0.000f, blue: 0.361f, alpha: 1); // #5c005c

		public static UIColor AccentMagenta => new UIColor (red: 0.706f, green: 0.000f, blue: 0.620f, alpha: 1); // #b4009e

		public static UIColor AccentMagentaLight => new UIColor (red: 0.890f, green: 0.000f, blue: 0.549f, alpha: 1); // #e3008c

		public static UIColor AccentPurpleDark => new UIColor (red: 0.196f, green: 0.078f, blue: 0.353f, alpha: 1); // #32145a

		public static UIColor AccentPurple => new UIColor (red: 0.361f, green: 0.176f, blue: 0.569f, alpha: 1); // #5c2d91

		public static UIColor AccentPurpleLight => new UIColor (red: 0.706f, green: 0.627f, blue: 1.000f, alpha: 1); // #b4a0ff

		public static UIColor AccentBlueDark => new UIColor (red: 0.000f, green: 0.125f, blue: 0.314f, alpha: 1); // #002050

		public static UIColor AccentBlueMid => new UIColor (red: 0.000f, green: 0.094f, blue: 0.561f, alpha: 1); // #00188f

		public static UIColor AccentBlue => new UIColor (red: 0.000f, green: 0.471f, blue: 0.843f, alpha: 1); // #0078d7

		public static UIColor AccentBlueLight => new UIColor (red: 0.000f, green: 0.737f, blue: 0.949f, alpha: 1); // #00bcf2

		public static UIColor AccentTealDark => new UIColor (red: 0.000f, green: 0.294f, blue: 0.314f, alpha: 1); // #004b50

		public static UIColor AccentTeal => new UIColor (red: 0.000f, green: 0.510f, blue: 0.447f, alpha: 1); // #008272

		public static UIColor AccentTealLight => new UIColor (red: 0.000f, green: 0.698f, blue: 0.580f, alpha: 1); // #00b294

		public static UIColor AccentGreenDark => new UIColor (red: 0.000f, green: 0.294f, blue: 0.110f, alpha: 1); // #004b1c

		public static UIColor AccentGreen => new UIColor (red: 0.063f, green: 0.486f, blue: 0.063f, alpha: 1); // #107c10

		public static UIColor AccentGreenLight => new UIColor (red: 0.729f, green: 0.847f, blue: 0.039f, alpha: 1); // #bad80a

		public static UIColor HashColor (string name)
		{
			int index = HashData.GetColor (name);
			return new UIColor (red: HashData.rgbRed [index], green: HashData.rgbGreen [index], blue: HashData.rgbBlue [index], alpha: 1);
		}
	}

}
