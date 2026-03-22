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
    public partial class Menu : UserControl
    {
        private kiosk mainForm;
        public Menu(kiosk Form)
        {
            InitializeComponent();
            mainForm = Form;

            Appointment_panel.Click += Appointment_panel_Click;
            Service_panel.Click += Service_panel_Click;

            //Apply gradient styler
            LabelPanelGradient.Apply(Main_panel,
            startColor: Color.FromArgb(45, 85, 200),
            endColor: Color.FromArgb(110, 175, 255),
            cornerRadius: 20);

            //Make labels transparent 
            Menulbl.BackColor = Color.Transparent;
            Appointment_lbl.BackColor = Color.Transparent;
            Service_lbl.BackColor = Color.Transparent;

            //Improve text visibility
            Menulbl.ForeColor = Color.White;
            Appointment_lbl.ForeColor = Color.White;
            Service_lbl.ForeColor = Color.White;
        }

        private void Appointment_panel_Click(object sender, EventArgs e)
        {
            // Always go to Patient (Old/New selection)
            mainForm.LoadUserControl(new Patient(mainForm));
        }

        private void Service_panel_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Do you already have an appointment?",
                "Appointment Check",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                // Skip old/new → go directly to PatientForm1
                mainForm.LoadUserControl(new OldPatient(mainForm));
            }
            else
            {
                mainForm.LoadUserControl(new Patient(mainForm));
            }
        }

        private void Dentist_panel_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Do you already have an appointment?",
                "Appointment Check",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                mainForm.LoadUserControl(new PatientForm1(mainForm));
            }
            else
            {
                mainForm.LoadUserControl(new Patient(mainForm));
            }
        }
        private void Appointment_panel_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void LogoTitile_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Service_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
