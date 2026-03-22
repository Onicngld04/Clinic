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
    public partial class PatientForm1 : UserControl
    {
        private kiosk mainForm;

        public PatientForm1(kiosk form)
        {
            InitializeComponent();
            mainForm = form;

            // Apply gradient styler
            LabelPanelGradient.Apply(PatientForm_panel,
                startColor: Color.FromArgb(45, 85, 200),
                endColor: Color.FromArgb(110, 175, 255),
                cornerRadius: 20);

            // Disable typing sa Gender ComboBox
            Gender_Cmb.DropDownStyle = ComboBoxStyle.DropDownList;

            // Add KeyPress validation events
            ContactName_txt.KeyPress += ContactName_txt_KeyPress;
            CpnumECP_txt.KeyPress += CpnumECP_txt_KeyPress;
            CpNum_txt.KeyPress += CpNum_txt_KeyPress;
            Name_txt.KeyPress += Name_txt_KeyPress;

            // Limit numbers to 11 digits
            CpNum_txt.MaxLength = 11;
            CpnumECP_txt.MaxLength = 11;

            LoadFromAppState();

            // ── Connect keyboard to all textboxes ──────────────────
            mainForm.AttachKeyboard(Name_txt);
            mainForm.AttachKeyboard(CpNum_txt);
            mainForm.AttachKeyboard(Address_txt);
            mainForm.AttachKeyboard(ContactName_txt);
            mainForm.AttachKeyboard(CpnumECP_txt);

            // ── Register Enter key tab order ───────────────────────
            mainForm.RegisterTabOrder(
                new List<TextBox>
                {
                    Name_txt,
                    CpNum_txt,
                    Address_txt,
                    ContactName_txt,
                    CpnumECP_txt
                },
                Submit_btn
            );

            // ── Tell the keyboard which boxes allow letters only ───
            mainForm.RegisterLetterOnlyBoxes(new List<TextBox>
            {
                Name_txt,
                ContactName_txt
            });

            // ── Tell the keyboard which boxes allow numbers only ───
            mainForm.RegisterNumberOnlyBoxes(new List<TextBox>
            {
                CpNum_txt,
                CpnumECP_txt
            });
        }

        // LOAD SAVED DATA
        private void LoadFromAppState()
        {
            bool hasPatientID = !string.IsNullOrEmpty(AppState.PatientID);
            bool hasDentist = !string.IsNullOrEmpty(AppState.PatientDentist);

            Name_txt.Text = AppState.PatientName ?? "";
            Gender_Cmb.Text = AppState.PatientGender ?? "";
            CpNum_txt.Text = AppState.PatientCpnum ?? "";
            Address_txt.Text = AppState.PatientAddress ?? "";
            ContactName_txt.Text = AppState.EmergencyName ?? "";
            CpnumECP_txt.Text = AppState.EmergencyNumber ?? "";
        }

        // VALIDATION
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(Name_txt.Text))
            {
                ShowError("Please enter patient name.", Name_txt);
                return false;
            }

            if (Name_txt.Text.Trim().Length < 2)
            {
                ShowError("Patient name must be at least 2 characters.", Name_txt);
                return false;
            }

            if (!Name_txt.Text.Trim().All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                ShowError("Patient name must contain letters only.", Name_txt);
                return false;
            }

            if (Gender_Cmb.SelectedIndex == -1)
            {
                ShowError("Please select gender.", Gender_Cmb);
                return false;
            }

            // ── Birth date validation ──────────────────────────────
            DateTime today = DateTime.Today;
            DateTime birthDate = Bday_dtp.Value.Date;

            if (birthDate >= today)
            {
                ShowError("Birth date must be in the past.", Bday_dtp);
                return false;
            }

            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;

            if (age > 120)
            {
                ShowError("Please enter a valid birth date.", Bday_dtp);
                return false;
            }

            if (string.IsNullOrWhiteSpace(CpNum_txt.Text))
            {
                ShowError("Please enter contact number.", CpNum_txt);
                return false;
            }

            if (!CpNum_txt.Text.All(char.IsDigit) || CpNum_txt.Text.Length != 11)
            {
                ShowError("Contact number must be exactly 11 digits.", CpNum_txt);
                return false;
            }

            if (!CpNum_txt.Text.StartsWith("09"))
            {
                ShowError("Contact number must start with 09.", CpNum_txt);
                return false;
            }

            if (string.IsNullOrWhiteSpace(Address_txt.Text))
            {
                ShowError("Please enter address.", Address_txt);
                return false;
            }

            if (Address_txt.Text.Trim().Length < 5)
            {
                ShowError("Please enter a complete address.", Address_txt);
                return false;
            }

            if (string.IsNullOrWhiteSpace(ContactName_txt.Text))
            {
                ShowError("Please enter emergency contact name.", ContactName_txt);
                return false;
            }

            if (ContactName_txt.Text.Trim().Length < 2)
            {
                ShowError("Emergency contact name must be at least 2 characters.", ContactName_txt);
                return false;
            }

            if (!ContactName_txt.Text.Trim().All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                ShowError("Emergency contact name must contain letters only.", ContactName_txt);
                return false;
            }

            if (string.IsNullOrWhiteSpace(CpnumECP_txt.Text))
            {
                ShowError("Please enter emergency contact number.", CpnumECP_txt);
                return false;
            }

            if (!CpnumECP_txt.Text.All(char.IsDigit) || CpnumECP_txt.Text.Length != 11)
            {
                ShowError("Emergency contact number must be exactly 11 digits.", CpnumECP_txt);
                return false;
            }

            if (!CpnumECP_txt.Text.StartsWith("09"))
            {
                ShowError("Emergency contact number must start with 09.", CpnumECP_txt);
                return false;
            }

            if (CpnumECP_txt.Text == CpNum_txt.Text)
            {
                ShowError(
                    "Emergency contact number must be different from patient contact number.",
                    CpnumECP_txt);
                return false;
            }

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

        // SUBMIT
        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            // ── Get birth year from Bday_dtp ───────────────────────
            int birthYear = Bday_dtp.Value.Year;

            // ── Generate Patient ID using birth year ───────────────
            if (string.IsNullOrEmpty(AppState.PatientID))
                AppState.PatientID = DatabaseHelper.GeneratePatientID(birthYear);

            // ── Save to AppState — ALL UPPERCASED ──────────────────
            AppState.PatientName = Name_txt.Text.Trim().ToUpper();
            AppState.PatientGender = Gender_Cmb.Text.ToUpper();
            AppState.PatientCpnum = CpNum_txt.Text.Trim();
            AppState.PatientAddress = Address_txt.Text.Trim().ToUpper();
            AppState.EmergencyName = ContactName_txt.Text.Trim().ToUpper();
            AppState.EmergencyNumber = CpnumECP_txt.Text.Trim();

            // ── Save to MySQL database — all text is already uppercased
            bool saved = DatabaseHelper.SavePatient(
                AppState.PatientID,
                AppState.PatientName,
                AppState.PatientGender,
                AppState.PatientCpnum,
                AppState.PatientAddress,
                AppState.EmergencyName,
                AppState.EmergencyNumber
            );

            if (!saved) return;

            // ── Show success message ───────────────────────────────
            MessageBox.Show(
                $"Registration successful!\n\n" +
                $"Name       : {AppState.PatientName}\n" +
                $"Patient ID : {AppState.PatientID}\n\n" +
                $"Please keep your Patient ID for future visits.",
                "Registration Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // ── FLOW CONTROL ───────────────────────────────────────
            if (string.IsNullOrEmpty(AppState.SelectedService))
            {
                mainForm.LoadUserControl(new Service(mainForm));
                return;
            }

            mainForm.LoadUserControl(new Queuing(mainForm));
        }

        // Allow letters and spaces only for Patient Name
        private void Name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        // Allow numbers only for Contact Number
        private void CpNum_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        // Allow letters and spaces only for Emergency Contact Name
        private void ContactName_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        // Allow numbers only for Emergency Contact Number
        private void CpnumECP_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        // BACK
        private void Back_btn_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new Patient(mainForm));
        }

        private void Back_btn_Click_1(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new Patient(mainForm));
        }
    }
}