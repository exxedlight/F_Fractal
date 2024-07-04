namespace Fractal
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Reset();    //	reset figure parametrs
		}

		List<int> Params;
		int iteration = 1;  //	current iteration

		private void startButton_Click(object sender, EventArgs e)
		{   //	draw button

			Bitmap bm = new Bitmap(drawPicBox.Width, drawPicBox.Height);    //	use bitmap for drawing
			Figure fig = new Figure(iteration);                             //	create figure class

			//	draw current figure iteration to bitmap
			bm = fig.Draw(drawPicBox, new Point(drawPicBox.Width / 2 - Params[0] / 2, drawPicBox.Height), iteration, Params);
			iteration++;

			using (Graphics g = drawPicBox.CreateGraphics())
			{   //	show it on picBox
				g.DrawImage(bm, 0, 0);
			}
		}

		private void resetButton_Click(object sender, EventArgs e)
		{   //	reset button
			Reset();
		}

		void Reset()
		{
			//	set iteration 1 and set default figure params
			iteration = 1;
			Params = new List<int>();
			Params.Add(600);
			Params.Add(120);
			Params.Add(420);
			Params.Add(180);
			Params.Add(Params[0] - 3 * Params[1]);
			Params.Add(Params[0] - Params[2]);
		}
	}
}