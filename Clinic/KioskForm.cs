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
    public partial class kiosk : Form
    {
        // 1min timer for idle state
        Timer idleTimer = new Timer();

        public kiosk()
        {
            InitializeComponent();  
            this.Load += kiosk_Load;

            WCM_panel.DoubleClick += OpenMenu;

            foreach (Control c in WCM_panel.Controls)
            {
                c.DoubleClick += OpenMenu;
            }

            //Detect form
            this.MouseMove += ResetIdleTimer;
            this.MouseClick += ResetIdleTimer;
            this.KeyPress += ResetIdleTimer;
        }
        private void kiosk_Load(object sender, EventArgs e)
        {
            WCM_panel.BringToFront();

            // Apply gradient main panel
            LabelPanelGradient.Apply(WCM_panel,
            startColor: Color.FromArgb(45, 85, 200),
            endColor: Color.FromArgb(110, 175, 255),
            cornerRadius: 20);

            //Make labels transparent 
            Welcome_lbl.BackColor = Color.Transparent;
            Gentel_lbl.BackColor = Color.Transparent;
            Click_lbl.BackColor = Color.Transparent;

            //Improve text visibility
            Welcome_lbl.ForeColor = Color.White;
            Gentel_lbl.ForeColor = Color.White;

            //Start idle timer
            idleTimer.Interval = 60000; 
            idleTimer.Tick += IdleTimer_Tick;
            idleTimer.Start();
        }

        private void IdleTimer_Tick(object sender, EventArgs e)
        {
            ShowIdle();
        }

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

            // register activity for idle reset
            RegisterActivity(idleUC);

            // reset idle timer
            idleTimer.Stop();
            idleTimer.Start();
        }

        public void LoadUserControl(UserControl uc)
        {
            WCM_panel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            WCM_panel.Controls.Add(uc);
            uc.BringToFront();

            // AUTO REGISTER ACTIVITY 
            RegisterActivity(uc);
        }

        private void GoHome()
        {
            WCM_panel.Controls.Clear();
            Gentel_lbl.Visible = true;
            WCM_panel.BringToFront();
        }

        //Detect activity for inside user control
        private void RegisterActivity(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.Click += ResetIdleTimer;
                c.MouseMove += ResetIdleTimer;
                c.KeyPress += ResetIdleTimer;
                if (c.HasChildren)
                {
                    RegisterActivity(c);
                }
            }
        }

        //Return to main form
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
        private void Welcome_panel_Paint(object sender, PaintEventArgs e)
        {
          
        }
        private void Gentel_Click(object sender, EventArgs e)
        {

        }
        private void Back_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void WCM_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logo1_pb_Click(object sender, EventArgs e)
        {

        }

        private void panelWelcome_Click_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Click_Click(object sender, EventArgs e)
        {

        }

        internal void LoadUserControl(object previousForm)
        {
            throw new NotImplementedException();
        }
    }
}
