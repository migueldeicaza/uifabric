
namespace Fabric {
	
	internal static class HashData
	{
		internal static float [] rgbRed   = new float [] { 0, 8, 16, 136, 180, 232, 218, 0, 0, 0, 168, 78 };
		internal static float [] rgbGreen = new float [] { 120, 130, 124, 23, 0, 17, 59, 111, 94, 78, 0, 37 };
		internal static float [] rgbBlue = new float [] { 215, 114, 16, 152, 158, 35, 1, 148, 80, 140, 0, 127 };

		internal static int GetColor (string name)
		{
			ulong randomNum = 3074457345618258791;
			foreach (var c in name) {
				randomNum = randomNum + (uint)c;
				randomNum = randomNum * 3074457345618258799;
			}
			return (int)(randomNum % (uint)rgbBlue.Length);
		}
	}
}
