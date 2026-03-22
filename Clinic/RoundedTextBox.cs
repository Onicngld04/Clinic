using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public class RoundedTextBox : TextBox
    {
        public int BorderRadius { get; set; } = 15;
        public Color BorderColor { get; set; } = Color.Gray;
        public int BorderSize { get; set; } = 2;

        public RoundedTextBox()
        {
            BorderStyle = BorderStyle.None;
            Multiline = true; // IMPORTANT para gumana ang height
            Padding = new Padding(10);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // WM_PAINT
            if (m.Msg == 0x000F)
            {
                using (Graphics g = CreateGraphics())
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    using (GraphicsPath path = GetRoundedPath(ClientRectangle, BorderRadius))
                    using (Pen pen = new Pen(BorderColor, BorderSize))
                    {
                        g.DrawPath(pen, path);
                    }
                }
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int r = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();

            return path;
        }

        public new event KeyPressEventHandler KeyPress
        {
            add { base.KeyPress += value; }
            remove { base.KeyPress -= value; }
        }
    }

}
