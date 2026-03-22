namespace Clinic
{
    partial class OldPatient
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Back_btn = new System.Windows.Forms.Button();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.PatientID_lbl = new System.Windows.Forms.Label();
            this.PatientInfo = new System.Windows.Forms.Label();
            this.OldPatientForm_panel = new System.Windows.Forms.Panel();
            this.PatientID_txt = new Clinic.RoundedTextBox();
            this.Note = new System.Windows.Forms.Label();
            this.OldPatientForm_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back_btn
            // 
            this.Back_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(235)))));
            this.Back_btn.Font = new System.Drawing.Font("Rockwell Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(25, 435);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(324, 143);
            this.Back_btn.TabIndex = 16;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Submit_btn
            // 
            this.Submit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Submit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(235)))));
            this.Submit_btn.Font = new System.Drawing.Font("Rockwell Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Submit_btn.Location = new System.Drawing.Point(662, 439);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(325, 136);
            this.Submit_btn.TabIndex = 15;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = false;
            // 
            // PatientID_lbl
            // 
            this.PatientID_lbl.AutoSize = true;
            this.PatientID_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.PatientID_lbl.Font = new System.Drawing.Font("Rockwell Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientID_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.PatientID_lbl.Location = new System.Drawing.Point(419, 187);
            this.PatientID_lbl.Name = "PatientID_lbl";
            this.PatientID_lbl.Size = new System.Drawing.Size(184, 44);
            this.PatientID_lbl.TabIndex = 7;
            this.PatientID_lbl.Text = "Patient ID no.";
            // 
            // PatientInfo
            // 
            this.PatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PatientInfo.AutoSize = true;
            this.PatientInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.PatientInfo.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.PatientInfo.Location = new System.Drawing.Point(196, 8);
            this.PatientInfo.Name = "PatientInfo";
            this.PatientInfo.Size = new System.Drawing.Size(651, 77);
            this.PatientInfo.TabIndex = 0;
            this.PatientInfo.Text = "Patient Information";
            // 
            // OldPatientForm_panel
            // 
            this.OldPatientForm_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OldPatientForm_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.OldPatientForm_panel.Controls.Add(this.PatientID_txt);
            this.OldPatientForm_panel.Controls.Add(this.Note);
            this.OldPatientForm_panel.Controls.Add(this.Back_btn);
            this.OldPatientForm_panel.Controls.Add(this.Submit_btn);
            this.OldPatientForm_panel.Controls.Add(this.PatientID_lbl);
            this.OldPatientForm_panel.Controls.Add(this.PatientInfo);
            this.OldPatientForm_panel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPatientForm_panel.Location = new System.Drawing.Point(0, 0);
            this.OldPatientForm_panel.Name = "OldPatientForm_panel";
            this.OldPatientForm_panel.Size = new System.Drawing.Size(1003, 581);
            this.OldPatientForm_panel.TabIndex = 7;
            // 
            // PatientID_txt
            // 
            this.PatientID_txt.BorderColor = System.Drawing.Color.Gray;
            this.PatientID_txt.BorderRadius = 15;
            this.PatientID_txt.BorderSize = 2;
            this.PatientID_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientID_txt.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientID_txt.Location = new System.Drawing.Point(321, 234);
            this.PatientID_txt.Multiline = true;
            this.PatientID_txt.Name = "PatientID_txt";
            this.PatientID_txt.Size = new System.Drawing.Size(372, 78);
            this.PatientID_txt.TabIndex = 18;
            this.PatientID_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note.Location = new System.Drawing.Point(192, 315);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(646, 54);
            this.Note.TabIndex = 17;
            this.Note.Text = "Enter your Patient ID above to quickly access your records.\r\n    Ensure your ID i" +
    "s correct for a smooth visit experience.";
            // 
            // OldPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OldPatientForm_panel);
            this.Name = "OldPatient";
            this.Size = new System.Drawing.Size(1003, 581);
            this.OldPatientForm_panel.ResumeLayout(false);
            this.OldPatientForm_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Label PatientID_lbl;
        private System.Windows.Forms.Label PatientInfo;
        private System.Windows.Forms.Panel OldPatientForm_panel;
        private System.Windows.Forms.Label Note;
        private Clinic.RoundedTextBox PatientID_txt;
    }
}
