namespace Clinic
{
    partial class PatientForm1
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
            this.PatientForm_panel = new System.Windows.Forms.Panel();
            this.Back_btn = new System.Windows.Forms.Button();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.CpNum_txt = new System.Windows.Forms.TextBox();
            this.CpNo = new System.Windows.Forms.Label();
            this.Bday_dtp = new System.Windows.Forms.DateTimePicker();
            this.bday = new System.Windows.Forms.Label();
            this.Gender_Cmb = new System.Windows.Forms.ComboBox();
            this.Gender = new System.Windows.Forms.Label();
            this.Address_txt = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.Label();
            this.PatientInfo = new System.Windows.Forms.Label();
            this.ContactP = new System.Windows.Forms.Label();
            this.ContactName_txt = new System.Windows.Forms.TextBox();
            this.ContactName = new System.Windows.Forms.Label();
            this.CpnumECP_txt = new System.Windows.Forms.TextBox();
            this.CpnumECP = new System.Windows.Forms.Label();
            this.PatientForm_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientForm_panel
            // 
            this.PatientForm_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PatientForm_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.PatientForm_panel.Controls.Add(this.CpnumECP_txt);
            this.PatientForm_panel.Controls.Add(this.CpnumECP);
            this.PatientForm_panel.Controls.Add(this.ContactName_txt);
            this.PatientForm_panel.Controls.Add(this.ContactName);
            this.PatientForm_panel.Controls.Add(this.ContactP);
            this.PatientForm_panel.Controls.Add(this.Back_btn);
            this.PatientForm_panel.Controls.Add(this.Submit_btn);
            this.PatientForm_panel.Controls.Add(this.CpNum_txt);
            this.PatientForm_panel.Controls.Add(this.CpNo);
            this.PatientForm_panel.Controls.Add(this.Bday_dtp);
            this.PatientForm_panel.Controls.Add(this.bday);
            this.PatientForm_panel.Controls.Add(this.Gender_Cmb);
            this.PatientForm_panel.Controls.Add(this.Gender);
            this.PatientForm_panel.Controls.Add(this.Address_txt);
            this.PatientForm_panel.Controls.Add(this.Address);
            this.PatientForm_panel.Controls.Add(this.Name_txt);
            this.PatientForm_panel.Controls.Add(this.FName);
            this.PatientForm_panel.Controls.Add(this.PatientInfo);
            this.PatientForm_panel.Location = new System.Drawing.Point(1, 0);
            this.PatientForm_panel.Name = "PatientForm_panel";
            this.PatientForm_panel.Size = new System.Drawing.Size(1003, 581);
            this.PatientForm_panel.TabIndex = 5;
            // 
            // Back_btn
            // 
            this.Back_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(235)))));
            this.Back_btn.Font = new System.Drawing.Font("Rockwell Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(25, 433);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(324, 143);
            this.Back_btn.TabIndex = 16;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click_1);
            // 
            // Submit_btn
            // 
            this.Submit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Submit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(235)))));
            this.Submit_btn.Font = new System.Drawing.Font("Rockwell Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Submit_btn.Location = new System.Drawing.Point(662, 436);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(325, 136);
            this.Submit_btn.TabIndex = 15;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = false;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // CpNum_txt
            // 
            this.CpNum_txt.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpNum_txt.Location = new System.Drawing.Point(128, 385);
            this.CpNum_txt.Multiline = true;
            this.CpNum_txt.Name = "CpNum_txt";
            this.CpNum_txt.Size = new System.Drawing.Size(309, 39);
            this.CpNum_txt.TabIndex = 12;
            // 
            // CpNo
            // 
            this.CpNo.AutoSize = true;
            this.CpNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.CpNo.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpNo.ForeColor = System.Drawing.SystemColors.Control;
            this.CpNo.Location = new System.Drawing.Point(129, 351);
            this.CpNo.Name = "CpNo";
            this.CpNo.Size = new System.Drawing.Size(166, 31);
            this.CpNo.TabIndex = 11;
            this.CpNo.Text = "Cellphone Number";
            // 
            // Bday_dtp
            // 
            this.Bday_dtp.Font = new System.Drawing.Font("Rockwell Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bday_dtp.Location = new System.Drawing.Point(483, 132);
            this.Bday_dtp.Name = "Bday_dtp";
            this.Bday_dtp.Size = new System.Drawing.Size(372, 45);
            this.Bday_dtp.TabIndex = 10;
            // 
            // bday
            // 
            this.bday.AutoSize = true;
            this.bday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.bday.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bday.ForeColor = System.Drawing.SystemColors.Control;
            this.bday.Location = new System.Drawing.Point(484, 99);
            this.bday.Name = "bday";
            this.bday.Size = new System.Drawing.Size(102, 31);
            this.bday.TabIndex = 9;
            this.bday.Text = "Birth-Date";
            // 
            // Gender_Cmb
            // 
            this.Gender_Cmb.Font = new System.Drawing.Font("Rockwell Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_Cmb.FormattingEnabled = true;
            this.Gender_Cmb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender_Cmb.Location = new System.Drawing.Point(129, 300);
            this.Gender_Cmb.Name = "Gender_Cmb";
            this.Gender_Cmb.Size = new System.Drawing.Size(186, 42);
            this.Gender_Cmb.TabIndex = 6;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Gender.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.ForeColor = System.Drawing.SystemColors.Control;
            this.Gender.Location = new System.Drawing.Point(129, 266);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(71, 31);
            this.Gender.TabIndex = 5;
            this.Gender.Text = "Gender";
            // 
            // Address_txt
            // 
            this.Address_txt.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_txt.Location = new System.Drawing.Point(129, 218);
            this.Address_txt.Multiline = true;
            this.Address_txt.Name = "Address_txt";
            this.Address_txt.Size = new System.Drawing.Size(309, 39);
            this.Address_txt.TabIndex = 4;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Address.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.SystemColors.Control;
            this.Address.Location = new System.Drawing.Point(129, 184);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(79, 31);
            this.Address.TabIndex = 3;
            this.Address.Text = "Address";
            // 
            // Name_txt
            // 
            this.Name_txt.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_txt.Location = new System.Drawing.Point(129, 138);
            this.Name_txt.Multiline = true;
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(309, 39);
            this.Name_txt.TabIndex = 2;
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.FName.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName.ForeColor = System.Drawing.SystemColors.Control;
            this.FName.Location = new System.Drawing.Point(129, 104);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(61, 31);
            this.FName.TabIndex = 1;
            this.FName.Text = "Name";
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
            // ContactP
            // 
            this.ContactP.AutoSize = true;
            this.ContactP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.ContactP.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactP.ForeColor = System.Drawing.SystemColors.Control;
            this.ContactP.Location = new System.Drawing.Point(484, 184);
            this.ContactP.Name = "ContactP";
            this.ContactP.Size = new System.Drawing.Size(242, 31);
            this.ContactP.TabIndex = 17;
            this.ContactP.Text = "Emergency Contact Person";
            // 
            // ContactName_txt
            // 
            this.ContactName_txt.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactName_txt.Location = new System.Drawing.Point(484, 253);
            this.ContactName_txt.Multiline = true;
            this.ContactName_txt.Name = "ContactName_txt";
            this.ContactName_txt.Size = new System.Drawing.Size(309, 39);
            this.ContactName_txt.TabIndex = 19;
            // 
            // ContactName
            // 
            this.ContactName.AutoSize = true;
            this.ContactName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.ContactName.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactName.ForeColor = System.Drawing.SystemColors.Control;
            this.ContactName.Location = new System.Drawing.Point(484, 219);
            this.ContactName.Name = "ContactName";
            this.ContactName.Size = new System.Drawing.Size(61, 31);
            this.ContactName.TabIndex = 18;
            this.ContactName.Text = "Name";
            // 
            // CpnumECP_txt
            // 
            this.CpnumECP_txt.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpnumECP_txt.Location = new System.Drawing.Point(483, 329);
            this.CpnumECP_txt.Multiline = true;
            this.CpnumECP_txt.Name = "CpnumECP_txt";
            this.CpnumECP_txt.Size = new System.Drawing.Size(309, 39);
            this.CpnumECP_txt.TabIndex = 21;
            // 
            // CpnumECP
            // 
            this.CpnumECP.AutoSize = true;
            this.CpnumECP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.CpnumECP.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpnumECP.ForeColor = System.Drawing.SystemColors.Control;
            this.CpnumECP.Location = new System.Drawing.Point(484, 295);
            this.CpnumECP.Name = "CpnumECP";
            this.CpnumECP.Size = new System.Drawing.Size(166, 31);
            this.CpnumECP.TabIndex = 20;
            this.CpnumECP.Text = "Cellphone Number";
            // 
            // PatientForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PatientForm_panel);
            this.Name = "PatientForm1";
            this.Size = new System.Drawing.Size(1003, 581);
            this.PatientForm_panel.ResumeLayout(false);
            this.PatientForm_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PatientForm_panel;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.TextBox CpNum_txt;
        private System.Windows.Forms.Label CpNo;
        private System.Windows.Forms.DateTimePicker Bday_dtp;
        private System.Windows.Forms.Label bday;
        private System.Windows.Forms.ComboBox Gender_Cmb;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.TextBox Address_txt;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.Label PatientInfo;
        private System.Windows.Forms.TextBox ContactName_txt;
        private System.Windows.Forms.Label ContactName;
        private System.Windows.Forms.Label ContactP;
        private System.Windows.Forms.TextBox CpnumECP_txt;
        private System.Windows.Forms.Label CpnumECP;
    }
}
