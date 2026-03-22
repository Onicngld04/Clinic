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
    public partial class Patient : UserControl
    {
        private readonly kiosk mainForm;
        public Patient(kiosk Form)
        {
            InitializeComponent();
            mainForm = Form;

            NewPatient_btn.Click += NewPatient_btn_Click;
            OldPatient_btn.Click += OldPatient_btn_Click;
            BackPF_btn.Click += BackPF_btn_Click;

            //Apply gradient styler
            LabelPanelGradient.Apply(OldNewbtn_panel,
            startColor: Color.FromArgb(45, 85, 200),
            endColor: Color.FromArgb(110, 175, 255),
            cornerRadius: 20);
        }
        private void NewPatient_btn_Click(object sender, EventArgs e)
        {
            AppState.IsoldPatient = false;
            mainForm.LoadUserControl(new PatientForm1 (mainForm));
        }
        private void OldPatient_btn_Click(object sender, EventArgs e)
        {
            AppState.IsoldPatient = true;
            mainForm.LoadUserControl(new OldPatient(mainForm));
        }
        private void BackPF_btn_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new Menu(mainForm));
        }
    }
}
