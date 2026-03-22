using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.styler
{
    internal class SidebarStyler
    {
        private static Button _activeButton;

        public static void ApplySidebar(Panel sidebar)
        {
            EnableDoubleBuffer(sidebar);

            foreach (Control c in sidebar.Controls)
            {
                if (c is Button btn)
                    StyleButton(btn);
            }
        }

        private static void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.Black;
            btn.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Cursor = Cursors.Hand;

            btn.Click += (s, e) => SetActive(btn);
            btn.Paint += DrawButton;
        }

        public static void SetActive(Button btn)
        {
            if (_activeButton != null)
                _activeButton.Invalidate();

            _activeButton = btn;
            btn.Invalidate();
        }

        private static void DrawButton(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, btn.Width - 1, btn.Height - 1);

            if (btn == _activeButton)
            {
                // ACTIVE BUTTON (filled rounded box)
                using (GraphicsPath path = RoundedRect(rect, 20))
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255, 180)))
                {
                    e.Graphics.FillPath(brush, path);
                }

                btn.ForeColor = Color.Black;
            }
            else
            {
                // NORMAL BUTTON (no fill)
                btn.ForeColor = Color.Black;
            }

            // Draw text manually (para centered parin)
            TextRenderer.DrawText(
                e.Graphics,
                btn.Text,
                btn.Font,
                rect,
                btn.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }

        private static GraphicsPath RoundedRect(Rectangle r, int radius)
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

        private static void EnableDoubleBuffer(Control c)
        {
            typeof(Control)
                .GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(c, true, null);
        }
    }
}
