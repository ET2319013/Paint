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

		private Bitmap _bmp;

		public ColorTool(Bitmap bmp) { _bmp = bmp; }
		public Bitmap Recolor(Point pt, Color oldcolor, Color newcolor)
		{
			toRecolor.Clear();	
			RecolorWithNeighbours(pt, oldcolor, newcolor);
			foreach(var point in toRecolor)
			{
				_bmp.SetPixel(point.X, point.Y, newcolor);
			}
			return _bmp;
		}

		private HashSet<Point> toRecolor = new();

		private void RecolorWithNeighbours(Point pt, Color oldcolor, Color newcolor)
		{
			var curColor = _bmp.GetPixel(pt.X, pt.Y);
			if(ColorsEqual(curColor, oldcolor))
			{
				toRecolor.Add(pt);
				List<Point> Neighbours = new()
				{
					new Point(pt.X, pt.Y + 1),
					new Point(pt.X, pt.Y - 1),
					new Point(pt.X - 1, pt.Y),
					new Point(pt.X + 1, pt.Y)
				};

				foreach(var point in Neighbours)
				{
					if (point.X >= 0 && point.Y > 0 && point.X < _bmp.Width && point.Y < _bmp.Height && !toRecolor.Contains(point))
					{
						RecolorWithNeighbours(point, oldcolor, newcolor);
					}
				}
			}
		}

		private static readonly int Accurancy = 0;
		//
		
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
