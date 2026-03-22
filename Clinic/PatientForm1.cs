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

            //Apply gradient styler
            LabelPanelGradient.Apply(PatientForm_panel,
            startColor: Color.FromArgb(45, 85, 200),
            endColor: Color.FromArgb(110, 175, 255),
            cornerRadius: 20);

            //  Disable typing sa Gender ComboBox
            Gender_Cmb.DropDownStyle = ComboBoxStyle.DropDownList;

            // Add KeyPress validation events
            ContactName_txt.KeyPress += ContactName_txt_KeyPress;
            CpnumECP_txt.KeyPress += CpnumECP_txt_KeyPress;

            // Limit cp number to 11 digits
            CpnumECP_txt.MaxLength = 11;

            LoadFromAppState();
        }

        // LOAD SAVED DATA
        private void LoadFromAppState()
        {
            bool hasPatientID = !string.IsNullOrEmpty(AppState.PatientID);
            bool hasDentist = !string.IsNullOrEmpty(AppState.PatientDentist);

            // Restore data
            Name_txt.Text = AppState.PatientName ?? "";
            Gender_Cmb.Text = AppState.PatientGender ?? "";
            CpNum_txt.Text = AppState.PatientCpnum ?? "";
            Address_txt.Text = AppState.PatientAddress ?? "";

            // Contact Person incase of emergency
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

            if (Gender_Cmb.SelectedIndex == -1)
            {
                ShowError("Please select gender.", Gender_Cmb);
                return false;
            }

            if (string.IsNullOrWhiteSpace(CpNum_txt.Text) ||
                !CpNum_txt.Text.All(char.IsDigit) ||
                CpNum_txt.Text.Length != 11)
            {
                ShowError("Contact number must be 11 digits.", CpNum_txt);
                return false;
            }

            if (string.IsNullOrWhiteSpace(Address_txt.Text))
            {
                ShowError("Please enter address.", Address_txt);
                return false;
            }

            if (string.IsNullOrWhiteSpace(ContactName_txt.Text) ||
                !ContactName_txt.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                ShowError("Please enter emergency contact name.", ContactName_txt);
                return false;
            }

            if (string.IsNullOrWhiteSpace(CpnumECP_txt.Text) ||
                !CpnumECP_txt.Text.All(char.IsDigit) ||
                CpnumECP_txt.Text.Length != 11)
            {
                ShowError("Emergency contact number must be 11 digits.", CpnumECP_txt);
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

        // SUBMIT (SINGLE FLOW)
        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            // Generate Patient ID once (NEW PATIENT)
            if (string.IsNullOrEmpty(AppState.PatientID))
            {
                AppState.PatientID = "P" + new Random().Next(1000, 9999);
            }

            // SAVE DATA
            AppState.PatientName = Name_txt.Text.Trim();
            AppState.PatientGender = Gender_Cmb.Text;
            AppState.PatientCpnum = CpNum_txt.Text;
            AppState.PatientAddress = Address_txt.Text;
            AppState.EmergencyName = ContactName_txt.Text.Trim();
            AppState.EmergencyNumber = CpnumECP_txt.Text;


            // FLOW CONTROL (NO GOING BACK)
            if (string.IsNullOrEmpty(AppState.SelectedService))
            {
                // Step 1 - Service
                mainForm.LoadUserControl(new Service(mainForm));
                return;
            }

            // Step 2 - Queuing (Final Step)
            MessageBox.Show(
                "Information confirmed.\nPlease wait for your queue number.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            mainForm.LoadUserControl(new Queuing(mainForm));
        }

        // Allow letters and spaces only for Emergency Contact Name
        private void ContactName_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //  Allow numbers only for Emergency Contact Number
        private void CpnumECP_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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

