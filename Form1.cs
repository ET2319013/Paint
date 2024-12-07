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

	}
}
