using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
	internal class ColorTool
	{
		public static void Recolor(Bitmap bmp, Point pt, Color oldcolor, Color newcolor)
		{
			List<List<bool>> visited = new List<List<bool>>();
			for(int i = 0; i < 3; i++)
			{
				List<bool> v = new List<bool>();
				v.Add(false);	
				v.Add(false);
				v.Add(false);
				visited.Add(v);

			}
			visited[1][1] = true;
			RecolorWithNeighbours(bmp, pt, oldcolor, newcolor, visited);
		}

		public static void RecolorWithNeighbours(Bitmap bmp, Point pt, Color oldcolor, Color newcolor, List<List<bool>> visited)
		{
			if(pt.X < 0  || pt.Y < 0 || pt.X >= bmp.Width || pt.Y >= bmp.Height) 
				return;
			var curColor = bmp.GetPixel(pt.X, pt.Y);
			if(ColorsEqual(curColor, oldcolor))
			{
				//for(var i = -1; i <= 1; i++) 
				//{
				//	for (var j = -1; j <= 1; j++)
				//	{
				//		if(i != 0 || j != 0 || !visited[i + 1][j+1])
				//		{
				//			var nexPoint = new Point(pt.X + i, pt.Y +j);
				//			RecolorWithNeighbours(bmp, nexPoint, oldcolor, newcolor, visited);
				//			visited[i + 1][j + 1] = true;
				//		}
				//	}
				//}
				bmp.SetPixel(pt.X, pt.Y, newcolor);
			}

		}

		private static int Accurancy = 1;
		
		private static bool ColorsEqual(Color color1, Color color2)
		{
			return Math.Abs(color1.R - color2.R) <= Accurancy && Math.Abs(color1.G - color2.G) <= Accurancy &&
				Math.Abs(color1.B - color2.B) <= Accurancy && Math.Abs(color1.A - color2.A) <= Accurancy;
		}

		public static void RecolorUsingBitmapData(Bitmap bmp, Point pt, Color oldcolor, Color newcolor)
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
