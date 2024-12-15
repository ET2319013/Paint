namespace Paint
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//to test auto scroll, uncomment:
			//pictureBox1.Image = Image.FromFile();


		}

		private Bitmap bitmap = null;
		Color newColor = Color.White;

		private bool RecolorMode = false;
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (RecolorMode)
			{
				var mousePoint = pictureBox1.PointToClient(System.Windows.Forms.Control.MousePosition);
				var oldColor = bitmap.GetPixel(mousePoint.X, mousePoint.Y);

				ColorTool colorTool = new(bitmap);
				colorTool.Recolor(mousePoint, oldColor, newColor);
				pictureBox1.Image = bitmap;
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
			{
				bitmap = new(openFileDialog1.FileName);
				pictureBox1.Image = bitmap;
			}
		}

		private void chooseColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (bitmap != null && colorDialog1.ShowDialog(this) == DialogResult.OK)
			{
				newColor = colorDialog1.Color;
				RecolorMode = true;
			}
		}

		private void pictureBox1_MouseHover(object sender, EventArgs e)
		{
			if (!RecolorMode)
			{
				Cursor = Cursors.Default;
			}
			else
			{
				Cursor = Cursors.Hand;
			}
		}

		private void stopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RecolorMode = false;
			Cursor = Cursors.Default;
		}
	}
}
