using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planetas
{
	public class Custom_Border : Panel
	{
		private int borderWidth = 2;
		private Color borderColor = Color.Red;

		public int BorderWidth
		{
			get { return borderWidth; }
			set { borderWidth = value; Invalidate(); }
		}

		public Color BorderColor
		{
			get { return borderColor; }
			set { borderColor = value; Invalidate(); }
		}

		public Custom_Border()
		{
			// Enable double-buffering to reduce flickering
			SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
			UpdateStyles();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			// Create a Graphics object to draw the border
			using (Graphics g = e.Graphics)
			{
				// Draw the custom border
				using (Pen borderPen = new Pen(borderColor, borderWidth))
				{
					g.DrawRectangle(borderPen, ClientRectangle);
				}
			}
		}
	}
}
