using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
	internal class Figure
	{
		public Point start;
		int Iters = 0;
		public Figure(int iterations)
		{
			/*			   -a-
			 * ========================== |
			 * =                        = b
			 * =    ===================== |
			 * =    = b       -- c --
			 * =    ===========
			 * =              = |
			 * =              = b
			 * =              = |
			 * =    ===========
			 * =    =  -- d --
			 * =    =
			 * =    = |
			 * =    = e
			 * ======
			 *  - f -
			 */
			Iters = iterations;
			//flag = true;
		}

		public Bitmap DrawF(PictureBox box, Point begin, List<int> Params)
		{	//	draw F figure
			Bitmap bm = new Bitmap(box.Width, box.Height);

			using (Graphics g = Graphics.FromImage(bm))
			{
				Point current = begin;
				Pen p = new Pen(Color.ForestGreen, 20);

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
			return bm;
		}

		public Bitmap Draw(PictureBox box, Point begin, int iterations, List<int> Params)
		{	//	draw current iteration
			Bitmap bm = DrawF(box, begin, Params);

			for(int i = 1; i < iterations; i++)
			{
				bm = drawBuffer(bm);
			}

			return bm;
		}

		public Bitmap drawBuffer(Bitmap bm)
		{	//	draw iteration logic

			Bitmap bm2 = new Bitmap(bm.Width, bm.Height);	//	new bitmap

			using (Graphics g = Graphics.FromImage(bm2))
			{
				g.Clear(Color.Black);
				g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

				//	place 0.5-sized old bitmap on new bitmap
				g.DrawImage(bm, 0, 0, bm.Width / 2, bm.Height / 2);						//	left-up
				g.DrawImage(bm, bm.Width/2, 0, bm.Width / 2, bm.Height / 2);			//	right-up
				g.DrawImage(bm, bm.Width/4, bm.Height/2, bm.Width / 2, bm.Height / 2);	//	center-down

			}
			return bm2;
		}
	}
}
