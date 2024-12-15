namespace Paint
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			flowLayoutPanel1 = new FlowLayoutPanel();
			pictureBox1 = new PictureBox();
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			openToolStripMenuItem = new ToolStripMenuItem();
			colorToolStripMenuItem = new ToolStripMenuItem();
			chooseColorToolStripMenuItem = new ToolStripMenuItem();
			stopToolStripMenuItem = new ToolStripMenuItem();
			openFileDialog1 = new OpenFileDialog();
			colorDialog1 = new ColorDialog();
			flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.AutoScroll = true;
			flowLayoutPanel1.Controls.Add(pictureBox1);
			flowLayoutPanel1.Dock = DockStyle.Fill;
			flowLayoutPanel1.Location = new Point(0, 28);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(800, 422);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(3, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(125, 62);
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			pictureBox1.MouseHover += pictureBox1_MouseHover;
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, colorToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 28);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(46, 24);
			fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.Size = new Size(128, 26);
			openToolStripMenuItem.Text = "Open";
			openToolStripMenuItem.Click += openToolStripMenuItem_Click;
			// 
			// colorToolStripMenuItem
			// 
			colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chooseColorToolStripMenuItem, stopToolStripMenuItem });
			colorToolStripMenuItem.Name = "colorToolStripMenuItem";
			colorToolStripMenuItem.Size = new Size(59, 24);
			colorToolStripMenuItem.Text = "Color";
			// 
			// chooseColorToolStripMenuItem
			// 
			chooseColorToolStripMenuItem.Name = "chooseColorToolStripMenuItem";
			chooseColorToolStripMenuItem.Size = new Size(224, 26);
			chooseColorToolStripMenuItem.Text = "Choose color";
			chooseColorToolStripMenuItem.Click += chooseColorToolStripMenuItem_Click;
			// 
			// stopToolStripMenuItem
			// 
			stopToolStripMenuItem.Name = "stopToolStripMenuItem";
			stopToolStripMenuItem.Size = new Size(224, 26);
			stopToolStripMenuItem.Text = "Stop";
			stopToolStripMenuItem.Click += stopToolStripMenuItem_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|png|*.png";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Form1";
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private FlowLayoutPanel flowLayoutPanel1;
		private PictureBox pictureBox1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripMenuItem colorToolStripMenuItem;
		private ToolStripMenuItem chooseColorToolStripMenuItem;
		private OpenFileDialog openFileDialog1;
		private ColorDialog colorDialog1;
		private ToolStripMenuItem stopToolStripMenuItem;
	}
}
