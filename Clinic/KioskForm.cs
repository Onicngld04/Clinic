using Clinic.styler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    // ══════════════════════════════════════════════════════════════
    //  KeyboardDismissFilter
    // ══════════════════════════════════════════════════════════════
    public class KeyboardDismissFilter : IMessageFilter
    {
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_NCLBUTTONDOWN = 0x00A1;

        private readonly KeyboardControl _keyboard;

        public KeyboardDismissFilter(KeyboardControl keyboard)
        {
            _keyboard = keyboard;
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg != WM_LBUTTONDOWN && m.Msg != WM_NCLBUTTONDOWN)
                return false;

            if (!_keyboard.Visible)
                return false;

            Control clickedControl = Control.FromHandle(m.HWnd);
            Control parent = clickedControl;

            while (parent != null)
            {
                if (parent == _keyboard)
                    return false;
                parent = parent.Parent;
            }

            _keyboard.Visible = false;
            return false;
        }
    }

    public partial class kiosk : Form
    {
        // 1min timer for idle state
        Timer idleTimer = new Timer();

        // ── Shared keyboard ────────────────────────────────────────
        public KeyboardControl SharedKeyboard;

        // ── Message filter ─────────────────────────────────────────
        private KeyboardDismissFilter _dismissFilter;

        public kiosk()
        {
            InitializeComponent();
            this.Load += kiosk_Load;
            this.FormClosing += kiosk_FormClosing;

            WCM_panel.DoubleClick += OpenMenu;

            foreach (Control c in WCM_panel.Controls)
                c.DoubleClick += OpenMenu;

            this.MouseMove += ResetIdleTimer;
            this.MouseClick += ResetIdleTimer;
            this.KeyPress += ResetIdleTimer;

            SharedKeyboard = new KeyboardControl();
            SharedKeyboard.Visible = false;
            this.Controls.Add(SharedKeyboard);
            SharedKeyboard.BringToFront();

            _dismissFilter = new KeyboardDismissFilter(SharedKeyboard);
            Application.AddMessageFilter(_dismissFilter);
        }

        private void kiosk_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.RemoveMessageFilter(_dismissFilter);
        }

        // ── Attach keyboard to any textbox ─────────────────────────
        public void AttachKeyboard(TextBox txt)
        {
            txt.Enter += (s, e) =>
            {
                SharedKeyboard.TargetTextBox = txt;
                SharedKeyboard.Location = new Point(
                    (this.ClientSize.Width - SharedKeyboard.Width) / 2,
                    this.ClientSize.Height - SharedKeyboard.Height - 5
                );
                SharedKeyboard.Visible = true;
                SharedKeyboard.BringToFront();
            };

            txt.MouseDown += (s, e) =>
            {
                SharedKeyboard.TargetTextBox = txt;
                SharedKeyboard.Location = new Point(
                    (this.ClientSize.Width - SharedKeyboard.Width) / 2,
                    this.ClientSize.Height - SharedKeyboard.Height - 5
                );
                SharedKeyboard.Visible = true;
                SharedKeyboard.BringToFront();
            };
        }

        // ── Register tab order and submit button ───────────────────
        public void RegisterTabOrder(List<TextBox> textboxes, Button submitBtn)
        {
            SharedKeyboard.RegisterTabOrder(textboxes, submitBtn);
        }

        // ── Register letter-only textboxes ─────────────────────────
        public void RegisterLetterOnlyBoxes(List<TextBox> boxes)
        {
            SharedKeyboard.RegisterLetterOnlyBoxes(boxes);
        }

        // ── Register number-only textboxes ─────────────────────────
        public void RegisterNumberOnlyBoxes(List<TextBox> boxes)
        {
            SharedKeyboard.RegisterNumberOnlyBoxes(boxes);
        }

        private void kiosk_Load(object sender, EventArgs e)
        {
            WCM_panel.BringToFront();

            LabelPanelGradient.Apply(WCM_panel,
                startColor: Color.FromArgb(45, 85, 200),
                endColor: Color.FromArgb(110, 175, 255),
                cornerRadius: 20);

            Welcome_lbl.BackColor = Color.Transparent;
            Gentel_lbl.BackColor = Color.Transparent;
            Click_lbl.BackColor = Color.Transparent;

            Welcome_lbl.ForeColor = Color.White;
            Gentel_lbl.ForeColor = Color.White;

            idleTimer.Interval = 60000;
            idleTimer.Tick += IdleTimer_Tick;
            idleTimer.Start();
        }

        private void IdleTimer_Tick(object sender, EventArgs e) => ShowIdle();

        private void ResetIdleTimer(object sender, EventArgs e)
        {
            idleTimer.Stop();
            idleTimer.Start();
        }

        private void ShowIdle()
        {
            WCM_panel.Controls.Clear();
            IdleForm idleUC = new IdleForm(this);
            LoadUserControl(idleUC);
            RegisterActivity(idleUC);
            idleTimer.Stop();
            idleTimer.Start();
        }

        public void LoadUserControl(UserControl uc)
        {
            SharedKeyboard.Visible = false;
            SharedKeyboard.ClearTabOrder();

            WCM_panel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            WCM_panel.Controls.Add(uc);
            uc.BringToFront();

            SharedKeyboard.BringToFront();
            RegisterActivity(uc);
        }

        private void GoHome()
        {
            WCM_panel.Controls.Clear();
            Gentel_lbl.Visible = true;
            WCM_panel.BringToFront();
        }

        private void RegisterActivity(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.Click += ResetIdleTimer;
                c.MouseMove += ResetIdleTimer;
                c.KeyPress += ResetIdleTimer;
                if (c.HasChildren)
                    RegisterActivity(c);
            }
        }

        internal void ShowMainForm()
        {
            WCM_panel.Controls.Clear();
            Gentel_lbl.Visible = true;
            idleTimer.Stop();
            idleTimer.Start();
        }

        private void OpenMenu(object sender, EventArgs e)
        {
            Gentel_lbl.Visible = true;
            Menu menuUC = new Menu(this);
            LoadUserControl(menuUC);
        }

        internal void ShowKioskMainForm()
        {
            WCM_panel.Controls.Clear();
            Gentel_lbl.Visible = true;
            WCM_panel.BringToFront();
        }

        private void Welcome_panel_Paint(object sender, PaintEventArgs e) { }
        private void Gentel_Click(object sender, EventArgs e) { }
        private void Back_panel_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void Welcome_Click(object sender, EventArgs e) { }
        private void WCM_panel_Paint(object sender, PaintEventArgs e) { }
        private void Logo1_pb_Click(object sender, EventArgs e) { }
        private void panelWelcome_Click_Paint(object sender, PaintEventArgs e) { }
        private void Click_Click(object sender, EventArgs e) { }
    }
}