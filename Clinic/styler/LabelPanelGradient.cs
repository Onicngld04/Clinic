using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.styler
{
    internal class LabelPanelGradient
    {
            public static void Apply(
                Panel panel,
                Color? startColor = null,
                Color? endColor = null,
                int cornerRadius = 12)
            {
                Color top = startColor ?? Color.FromArgb(45, 85, 200);
                Color bottom = endColor ?? Color.FromArgb(110, 175, 255);

                panel.BackColor = Color.Transparent;
                panel.Resize += (s, e) => panel.Invalidate();

                panel.Paint += (s, e) =>
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    Rectangle rect = panel.ClientRectangle;
                    if (rect.Width <= 0 || rect.Height <= 0) return;

                    using (GraphicsPath path = GetRoundedRect(rect, cornerRadius))
                    using (LinearGradientBrush brush =
                        new LinearGradientBrush(rect, top, bottom, LinearGradientMode.Vertical))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                };
            }

            private static GraphicsPath GetRoundedRect(Rectangle r, int radius)
            {
                GraphicsPath path = new GraphicsPath();
                int d = radius * 2;

                path.AddArc(r.X, r.Y, d, d, 180, 90);
                path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
                path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
                path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
                path.CloseFigure();

                return path;
            }
        }
}
