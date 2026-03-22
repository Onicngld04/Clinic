using Clinic.styler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class OldPatient : UserControl
    {
        private readonly kiosk mainForm;

        public OldPatient(kiosk form)
        {
            InitializeComponent();
            mainForm = form;

            Submit_btn.Click += Submit_btn_Click;
            Back_btn.Click += Back_btn_Click;

            // Apply gradient styler
            LabelPanelGradient.Apply(OldPatientForm_panel,
                startColor: Color.FromArgb(45, 85, 200),
                endColor: Color.FromArgb(110, 175, 255),
                cornerRadius: 20);

            // ── Connect keyboard to textbox ────────────────────────
            mainForm.AttachKeyboard(PatientID_txt);

            // ── Register Enter key tab order ───────────────────────
            mainForm.RegisterTabOrder(
                new List<TextBox> { PatientID_txt },
                Submit_btn
            );
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            string patientID = PatientID_txt.Text.Trim().ToUpper();

            // ── Validation 1: Empty check ──────────────────────────
            if (string.IsNullOrWhiteSpace(patientID))
            {
                ShowError("Please enter your Patient ID.", PatientID_txt);
                return;
            }

            // ── Validation 2: Format check (P-YYYY-XXXX) ──────────
            if (!IsValidPatientIDFormat(patientID))
            {
                ShowError(
                    "Invalid Patient ID format.\nExpected format: P-YYYY-0001",
                    PatientID_txt);
                return;
            }

            // ── Validation 3: Check database if patient exists ─────
            bool exists = DatabaseHelper.PatientExists(patientID);

            if (!exists)
            {
                ShowError(
                    $"Patient ID '{patientID}' was not found.\n\n" +
                    "If you are a new patient please go back\n" +
                    "and register as a New Patient.",
                    PatientID_txt);
                return;
            }

            // ── Get patient name from database ─────────────────────
            string patientName = DatabaseHelper.GetPatientName(patientID);

            // ── Save to AppState ───────────────────────────────────
            AppState.PatientID = patientID;
            AppState.PatientName = patientName;

            // ── Welcome message shows the patient's name ───────────
            MessageBox.Show(
                $"Welcome back, {patientName}!",
                "Patient Found",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            mainForm.LoadUserControl(new Service(mainForm));
        }

        // ── Validate format: P-YYYY-XXXX ──────────────────────────
        private bool IsValidPatientIDFormat(string id)
        {
            if (id.Length < 10) return false;
            if (!id.StartsWith("P-")) return false;

            string[] parts = id.Split('-');

            if (parts.Length != 3) return false;
            if (parts[1].Length != 4) return false;
            if (!int.TryParse(parts[1], out _)) return false;
            if (parts[2].Length != 4) return false;
            if (!int.TryParse(parts[2], out _)) return false;

            return true;
        }

        private void ShowError(string message, Control control)
        {
            MessageBox.Show(
                message,
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            control.Focus();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new Patient(mainForm));
        }

        public class RoundedTextBox : TextBox
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                using (GraphicsPath path = new GraphicsPath())
                {
                    int radius = 15;
                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
                    path.CloseAllFigures();
                    this.Region = new Region(path);
                }
            }
        }

        private void submitButton_MouseEnter(object sender, EventArgs e)
        {
            Submit_btn.BackColor = Color.LightBlue;
        }

        private void submitButton_MouseLeave(object sender, EventArgs e)
        {
            Submit_btn.BackColor = Color.DodgerBlue;
        }
    }
}