namespace Clinic
{
    partial class Queuing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Queuing));
            this.Intraction_lbl = new System.Windows.Forms.Label();
            this.Button_panel = new System.Windows.Forms.Panel();
            this.Back4_btn = new System.Windows.Forms.Button();
            this.Print_btn = new System.Windows.Forms.Button();
            this.Instraction_panel = new System.Windows.Forms.Panel();
            this.Queuing_panel = new System.Windows.Forms.Panel();
            this.Que_panel = new System.Windows.Forms.Panel();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.number_label = new System.Windows.Forms.Label();
            this.lblQueueNo = new System.Windows.Forms.Label();
            this.PatientName_lbl = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPatientNo = new System.Windows.Forms.Label();
            this.PatientID_lbl = new System.Windows.Forms.Label();
            this.lblservice = new System.Windows.Forms.Label();
            this.Service_lbl = new System.Windows.Forms.Label();
            this.TimeDate_lbl = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.DateTimePicker();
            this.Button_panel.SuspendLayout();
            this.Instraction_panel.SuspendLayout();
            this.Queuing_panel.SuspendLayout();
            this.Que_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Intraction_lbl
            // 
            this.Intraction_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Intraction_lbl.AutoSize = true;
            this.Intraction_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intraction_lbl.ForeColor = System.Drawing.Color.White;
            this.Intraction_lbl.Location = new System.Drawing.Point(14, 14);
            this.Intraction_lbl.Name = "Intraction_lbl";
            this.Intraction_lbl.Size = new System.Drawing.Size(383, 120);
            this.Intraction_lbl.TabIndex = 0;
            this.Intraction_lbl.Text = "Note:\r\nPlease wait in the waiting area.\r\nYour queue number will be called shortly" +
    ".\r\nThank you for your patience.";
            // 
            // Button_panel
            // 
            this.Button_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_panel.Controls.Add(this.Back4_btn);
            this.Button_panel.Controls.Add(this.Print_btn);
            this.Button_panel.Location = new System.Drawing.Point(557, 410);
            this.Button_panel.Name = "Button_panel";
            this.Button_panel.Size = new System.Drawing.Size(418, 149);
            this.Button_panel.TabIndex = 6;
            // 
            // Back4_btn
            // 
            this.Back4_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(235)))));
            this.Back4_btn.Font = new System.Drawing.Font("Rockwell Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back4_btn.ForeColor = System.Drawing.Color.White;
            this.Back4_btn.Location = new System.Drawing.Point(231, 23);
            this.Back4_btn.Name = "Back4_btn";
            this.Back4_btn.Size = new System.Drawing.Size(148, 92);
            this.Back4_btn.TabIndex = 1;
            this.Back4_btn.Text = "Back";
            this.Back4_btn.UseVisualStyleBackColor = false;
            this.Back4_btn.Click += new System.EventHandler(this.Back4_btn_Click);
            // 
            // Print_btn
            // 
            this.Print_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(235)))));
            this.Print_btn.Font = new System.Drawing.Font("Rockwell Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_btn.ForeColor = System.Drawing.Color.White;
            this.Print_btn.Location = new System.Drawing.Point(42, 23);
            this.Print_btn.Name = "Print_btn";
            this.Print_btn.Size = new System.Drawing.Size(148, 92);
            this.Print_btn.TabIndex = 0;
            this.Print_btn.Text = "Print";
            this.Print_btn.UseVisualStyleBackColor = false;
            this.Print_btn.Click += new System.EventHandler(this.Print_btn_Click);
            // 
            // Instraction_panel
            // 
            this.Instraction_panel.Controls.Add(this.Intraction_lbl);
            this.Instraction_panel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instraction_panel.Location = new System.Drawing.Point(552, 225);
            this.Instraction_panel.Name = "Instraction_panel";
            this.Instraction_panel.Size = new System.Drawing.Size(410, 147);
            this.Instraction_panel.TabIndex = 5;
            // 
            // Queuing_panel
            // 
            this.Queuing_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Queuing_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Queuing_panel.Controls.Add(this.Que_panel);
            this.Queuing_panel.Controls.Add(this.logo_panel);
            this.Queuing_panel.Controls.Add(this.Button_panel);
            this.Queuing_panel.Controls.Add(this.Instraction_panel);
            this.Queuing_panel.Location = new System.Drawing.Point(0, 0);
            this.Queuing_panel.Name = "Queuing_panel";
            this.Queuing_panel.Size = new System.Drawing.Size(1003, 581);
            this.Queuing_panel.TabIndex = 13;
            // 
            // Que_panel
            // 
            this.Que_panel.Controls.Add(this.lblDateTime);
            this.Que_panel.Controls.Add(this.TimeDate_lbl);
            this.Que_panel.Controls.Add(this.lblservice);
            this.Que_panel.Controls.Add(this.Service_lbl);
            this.Que_panel.Controls.Add(this.lblPatientNo);
            this.Que_panel.Controls.Add(this.PatientID_lbl);
            this.Que_panel.Controls.Add(this.lblName);
            this.Que_panel.Controls.Add(this.PatientName_lbl);
            this.Que_panel.Controls.Add(this.lblQueueNo);
            this.Que_panel.Controls.Add(this.number_label);
            this.Que_panel.Location = new System.Drawing.Point(60, 225);
            this.Que_panel.Name = "Que_panel";
            this.Que_panel.Size = new System.Drawing.Size(471, 292);
            this.Que_panel.TabIndex = 7;
            // 
            // logo_panel
            // 
            this.logo_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo_panel.BackgroundImage")));
            this.logo_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo_panel.Location = new System.Drawing.Point(390, 10);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(207, 152);
            this.logo_panel.TabIndex = 8;
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_label.ForeColor = System.Drawing.Color.White;
            this.number_label.Location = new System.Drawing.Point(15, 26);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(99, 31);
            this.number_label.TabIndex = 0;
            this.number_label.Text = "Queue No:";
            this.number_label.Click += new System.EventHandler(this.number_label_Click);
            // 
            // lblQueueNo
            // 
            this.lblQueueNo.AutoSize = true;
            this.lblQueueNo.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueueNo.ForeColor = System.Drawing.Color.White;
            this.lblQueueNo.Location = new System.Drawing.Point(120, 14);
            this.lblQueueNo.Name = "lblQueueNo";
            this.lblQueueNo.Size = new System.Drawing.Size(202, 43);
            this.lblQueueNo.TabIndex = 1;
            this.lblQueueNo.Text = "Queue No.";
            // 
            // PatientName_lbl
            // 
            this.PatientName_lbl.AutoSize = true;
            this.PatientName_lbl.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientName_lbl.ForeColor = System.Drawing.Color.White;
            this.PatientName_lbl.Location = new System.Drawing.Point(15, 81);
            this.PatientName_lbl.Name = "PatientName_lbl";
            this.PatientName_lbl.Size = new System.Drawing.Size(135, 31);
            this.PatientName_lbl.TabIndex = 2;
            this.PatientName_lbl.Text = "Patient Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(156, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(141, 31);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "lblPatientName";
            // 
            // lblPatientNo
            // 
            this.lblPatientNo.AutoSize = true;
            this.lblPatientNo.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientNo.ForeColor = System.Drawing.Color.White;
            this.lblPatientNo.Location = new System.Drawing.Point(156, 139);
            this.lblPatientNo.Name = "lblPatientNo";
            this.lblPatientNo.Size = new System.Drawing.Size(116, 31);
            this.lblPatientNo.TabIndex = 5;
            this.lblPatientNo.Text = "lblPatientNo";
            // 
            // PatientID_lbl
            // 
            this.PatientID_lbl.AutoSize = true;
            this.PatientID_lbl.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientID_lbl.ForeColor = System.Drawing.Color.White;
            this.PatientID_lbl.Location = new System.Drawing.Point(15, 139);
            this.PatientID_lbl.Name = "PatientID_lbl";
            this.PatientID_lbl.Size = new System.Drawing.Size(107, 31);
            this.PatientID_lbl.TabIndex = 4;
            this.PatientID_lbl.Text = "Patient ID:";
            // 
            // lblservice
            // 
            this.lblservice.AutoSize = true;
            this.lblservice.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservice.ForeColor = System.Drawing.Color.White;
            this.lblservice.Location = new System.Drawing.Point(156, 183);
            this.lblservice.Name = "lblservice";
            this.lblservice.Size = new System.Drawing.Size(94, 31);
            this.lblservice.TabIndex = 7;
            this.lblservice.Text = "lblservice";
            // 
            // Service_lbl
            // 
            this.Service_lbl.AutoSize = true;
            this.Service_lbl.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Service_lbl.ForeColor = System.Drawing.Color.White;
            this.Service_lbl.Location = new System.Drawing.Point(15, 183);
            this.Service_lbl.Name = "Service_lbl";
            this.Service_lbl.Size = new System.Drawing.Size(132, 31);
            this.Service_lbl.TabIndex = 6;
            this.Service_lbl.Text = "Service Type:";
            // 
            // TimeDate_lbl
            // 
            this.TimeDate_lbl.AutoSize = true;
            this.TimeDate_lbl.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeDate_lbl.ForeColor = System.Drawing.Color.White;
            this.TimeDate_lbl.Location = new System.Drawing.Point(15, 240);
            this.TimeDate_lbl.Name = "TimeDate_lbl";
            this.TimeDate_lbl.Size = new System.Drawing.Size(113, 31);
            this.TimeDate_lbl.TabIndex = 8;
            this.TimeDate_lbl.Text = "Time/Date:";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(162, 234);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(302, 39);
            this.lblDateTime.TabIndex = 9;
            // 
            // Queuing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Queuing_panel);
            this.Name = "Queuing";
            this.Size = new System.Drawing.Size(1003, 581);
            this.Button_panel.ResumeLayout(false);
            this.Instraction_panel.ResumeLayout(false);
            this.Instraction_panel.PerformLayout();
            this.Queuing_panel.ResumeLayout(false);
            this.Que_panel.ResumeLayout(false);
            this.Que_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Intraction_lbl;
        private System.Windows.Forms.Panel Button_panel;
        private System.Windows.Forms.Button Back4_btn;
        private System.Windows.Forms.Button Print_btn;
        private System.Windows.Forms.Panel Instraction_panel;
        private System.Windows.Forms.Panel Queuing_panel;
        private System.Windows.Forms.Panel Que_panel;
        private System.Windows.Forms.Panel logo_panel;
        private System.Windows.Forms.Label lblQueueNo;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label PatientName_lbl;
        private System.Windows.Forms.DateTimePicker lblDateTime;
        private System.Windows.Forms.Label TimeDate_lbl;
        private System.Windows.Forms.Label lblservice;
        private System.Windows.Forms.Label Service_lbl;
        private System.Windows.Forms.Label lblPatientNo;
        private System.Windows.Forms.Label PatientID_lbl;
    }
}
