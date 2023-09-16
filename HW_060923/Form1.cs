using System.Drawing.Drawing2D;

namespace HW_060923
{
	public partial class Form1 : Form
	{
		Pen pen;
		Bitmap bm;
		Graphics g;

		public Form1()
		{
			InitializeComponent();
			pen = new Pen(Color.Black, 5);
			bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
		}

		private void bPrint_Click(object sender, EventArgs e)
		{
			g = Graphics.FromImage(pictureBox1.Image = bm);
			Matrix matrix = new Matrix(1, 0, 0, -1, 0, 0);
			g.Transform = matrix;
			g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);

			int x = -100;
			int y;
			int xPrevious;
			int yPrevious;

			switch (listBox1.Text) {
				case "1":
					xPrevious = -100;
					yPrevious = -100;

					while (x <= 100) {
						y = x;
						// Scale the coordinates as needed
						int pixelX = x * 5; // Adjust scaling factor
						int pixelY = y * 5; // Adjust scaling factor
						g.DrawLine(Pens.Black, xPrevious, yPrevious, pixelX, pixelY);

						xPrevious = pixelX;
						yPrevious = pixelY;
						x++;
					}
					break;

				case "2":
					xPrevious = -100;
					yPrevious = -100 * -100; // Initial y for x^2

					while (x <= 100) {
						y = x * x;
						int pixelX = x * 5; // Adjust scaling factor
						int pixelY = y * 5; // Adjust scaling factor
						g.DrawLine(Pens.Black, xPrevious, yPrevious, pixelX, pixelY);

						xPrevious = pixelX;
						yPrevious = pixelY;
						x++;
					}
					break;

				case "3":
					xPrevious = -100;
					yPrevious = 0; // Initial y for sqrt(x)

					while (x <= 100) {
						y = Math.Sqrt(Math.Max(x, 0)); // Ensure y is non-negative
						int pixelX = x * 5; // Adjust scaling factor
						int pixelY = (int)(y * 5); // Adjust scaling factor
						g.DrawLine(Pens.Black, xPrevious, yPrevious, pixelX, pixelY);

						xPrevious = pixelX;
						yPrevious = pixelY;
						x++;
					}
					break;
			}
		}
	}
}