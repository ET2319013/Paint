namespace Paint
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//to test auto scroll, uncomment:
			//pictureBox1.Image = Image.FromFile();
			bitmap = new(".//..//..//..//1.jpg");
			pictureBox1.Image = bitmap;

		}

		private Bitmap bitmap;

		private void button1_Click(object sender, EventArgs e)
		{
		}

		private bool RecolorMode = true;
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (RecolorMode)
			{
				var mousePoint = pictureBox1.PointToClient(System.Windows.Forms.Control.MousePosition);
				var oldColor = bitmap.GetPixel(mousePoint.X, mousePoint.Y);
				var newColor = Color.Black;
				ColorTool colorTool = new(bitmap);
				colorTool.Recolor(mousePoint, oldColor, newColor);
				pictureBox1.Image = bitmap;
			}
		}
	}
}
