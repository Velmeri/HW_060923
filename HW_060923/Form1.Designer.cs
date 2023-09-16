namespace HW_060923
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
			if (disposing && (components != null)) {
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
			pictureBox1 = new PictureBox();
			bPrint = new Button();
			listBox1 = new ListBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(12, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(776, 312);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// bPrint
			// 
			bPrint.BackgroundImageLayout = ImageLayout.None;
			bPrint.Location = new Point(584, 375);
			bPrint.Name = "bPrint";
			bPrint.Size = new Size(94, 29);
			bPrint.TabIndex = 1;
			bPrint.Text = "Print";
			bPrint.UseVisualStyleBackColor = true;
			bPrint.Click += bPrint_Click;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 20;
			listBox1.Items.AddRange(new object[] { "1", "2", "3" });
			listBox1.Location = new Point(231, 375);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(150, 24);
			listBox1.TabIndex = 2;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(listBox1);
			Controls.Add(bPrint);
			Controls.Add(pictureBox1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pictureBox1;
		private Button bPrint;
		private ListBox listBox1;
	}
}