using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
	internal class Draft
	{	
		
		//	=========================================		OLD CODE BACKUP

		// old event
		/*private void startButton_Click(object sender, EventArgs e)
		{
			/*Bitmap bm = new Bitmap(drawPicBox.Width, drawPicBox.Height);

			using (Graphics g = Graphics.FromImage(bm))
			{
				g.Clear(Color.Black);

				Figure fig = new Figure(iteration);

				fig.Draw(g, new Point(drawPicBox.Width / 2 - Params[0] / 2, drawPicBox.Height), iteration, Params);
				iteration += 1;
			}

			using (Graphics g = drawPicBox.CreateGraphics())
			{
				g.DrawImage(bm, 0, 0);
			}*/

		/*Bitmap bm = new Bitmap(drawPicBox.Width, drawPicBox.Height);
		Figure fig = new Figure(iteration);
		bm = fig.Draw(drawPicBox, new Point(drawPicBox.Width / 2 - Params[0] / 2, drawPicBox.Height), iteration, Params);
		iteration++;

		using (Graphics g = drawPicBox.CreateGraphics())
		{
			g.DrawImage(bm, 0, 0);
		}
	}*/

		//	old drawF
		/*
		public void DrawF(Graphics g, Point begin, List<int> Params)
		{
			Point current = begin;
			Pen p = new Pen(Color.ForestGreen, 1);

			current = begin;
			Point current2 = new Point(current.X, current.Y - Params[0]);
			g.DrawLine(p, current, current2);

			current = current2;
			current2 = new Point(current.X + Params[0], current.Y);
			g.DrawLine(p, current, current2);

			current = current2;
			current2 = new Point(current.X, current.Y + Params[1]);
			g.DrawLine(p, current, current2);

			current = current2;
			current2 = new Point(current.X - Params[2], current.Y);
			g.DrawLine(p, current, current2);

			current = current2;
			current2 = new Point(current.X, current.Y + Params[1]);
			g.DrawLine(p, current, current2);

			current = current2;
			current2 = new Point(current.X + Params[3], current.Y);
			g.DrawLine(p, current, current2);

			current = current2;
			current2 = new Point(current.X, current.Y + Params[1]);
			g.DrawLine(p, current, current2);

			current = current2;
			current2 = new Point(current.X - Params[3], current.Y);
			g.DrawLine(p, current, current2);

			current = current2;
			current2 = new Point(current.X, current.Y + Params[4]);
			g.DrawLine(p, current, current2);

			current = current2;
			current2 = new Point(current.X - Params[5], current.Y);
			g.DrawLine(p, current, current2);
		}
		*/

		//	old recursive
		/*
		bool flag = true;

		public void Draw(Graphics g, Point begin, int iteration, List<int> Params)
		{
			if (iteration <= 0) return;

			if (flag)
			{
				for (int j = 0; j < Params.Count; j++)
				{
					Params[j] = (int)(Params[j] / 2);
				}
				flag = false;
			}

			DrawF(g, begin, new List<int>(Params));
			
			if (iteration == 1) return;

			//if (iteration > 1)
			//{
				DrawF(g, new Point(begin.X - (int)(Params[0]), begin.Y - Params[0]), new List<int>(Params));
				DrawF(g, new Point(begin.X + (int)(Params[0]), begin.Y - Params[0]), new List<int>(Params));
			//}

			if (iteration == 2) return;

			for (int i = iteration - 1; i >= 0; i--)
			{
				Draw(g, new Point(begin.X - Params[0] * Iters, begin.Y - Params[0] * Iters), i, new List<int>(Params));
				Draw(g, new Point(begin.X + Params[0] * Iters, begin.Y - Params[0] * Iters), i, new List<int>(Params));
			}

		}
		*/

	}
}
