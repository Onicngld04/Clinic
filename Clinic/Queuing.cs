using Clinic.styler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class Queuing : UserControl
    {
        private kiosk mainForm;
        private bool isPrinted = false;

        public Queuing(kiosk form)
        {
            InitializeComponent();
            mainForm = form;

            LoadQueueInfo();

            Print_btn.Click += Print_btn_Click;
            Back4_btn.Click += Back4_btn_Click;

            // Disable back until printed (kiosk safety)
            Back4_btn.Enabled = false;

            //Apply gradient styler
            LabelPanelGradient.Apply(Queuing_panel,
            startColor: Color.FromArgb(45, 85, 200),
            endColor: Color.FromArgb(110, 175, 255),
            cornerRadius: 20);
        }

        // LOAD QUEUE INFORMATION
        private void LoadQueueInfo()
        {
            if (AppState.QueueNumber == 0)
                AppState.QueueNumber++;

            lblQueueNo.Text = AppState.QueueNumber.ToString("000");

            lblName.Text = AppState.PatientName;
            lblPatientNo.Text = AppState.PatientID;
            lblservice.Text = AppState.SelectedService;
            lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
        }

        // PRINT / SAVE QUEUE

        private void Print_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = $"Queue_{AppState.QueueNumber:000}.txt";
                string filePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    fileName
                );

                string content =
                    "MEDCORE DENTAL CLINIC\n" +
                    "-------------------------\n" +
                    $"Queue No      : {AppState.QueueNumber:000}\n" +
                    $"Name          : {AppState.PatientName}\n" +
                    $"Patient No    : {AppState.PatientID}\n" +
                    $"Service       : {AppState.SelectedService}\n" +
                    $"Date & Time   : {DateTime.Now:MM/dd/yyyy hh:mm tt}\n";

                File.WriteAllText(filePath, content);

                MessageBox.Show(
                    "Queue information saved successfully.",
                    "Print Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                isPrinted = true;
                Back4_btn.Enabled = true;

                // Reset state after printing
                AppState.Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to print queue.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        // BACK TO KIOSK HOME
        private void Back4_btn_Click(object sender, EventArgs e)
        {
            if (!isPrinted) return;
            Form frm = new kiosk();
            frm.ShowDialog();
        }

        private void number_label_Click(object sender, EventArgs e)
        {

        }
    }
}
    

