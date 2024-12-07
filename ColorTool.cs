using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
	internal class ColorTool
	{
		public static void Recolor(Bitmap bmp, Point pt, Color color)
		{

			bmp.GetPixel(pt.X, pt.Y);
			bmp.SetPixel(pt.X, pt.Y, color);

		}

		public static void RecolorUsingBitmapData(Bitmap bmp, Point pt, Color color)
		{
			//from https://learn.microsoft.com/

			Rectangle rect = new(0, 0, bmp.Width, bmp.Height);
			System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);

			// Get the address of the first line.
			IntPtr ptr = bmpData.Scan0;

			// Declare an array to hold the bytes of the bitmap.
			int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
			byte[] rgbValues = new byte[bytes];

			// Copy the RGB values into the array.
			System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

			// Set every third value to 255. A 24bpp bitmap will look red.  
			for (int counter = 2; counter < rgbValues.Length; counter += 3)
				rgbValues[counter] = 255;

			//TODO my own recolor 

			// Copy the RGB values back to the bitmap
			System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

			// Unlock the bits.
			bmp.UnlockBits(bmpData);

		}
	}
}
