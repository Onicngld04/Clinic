namespace Clinic
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.OldNewbtn_panel = new System.Windows.Forms.Panel();
            this.NewPatient_btn = new System.Windows.Forms.Button();
            this.OldPatient_btn = new System.Windows.Forms.Button();
            this.BackPF_btn = new System.Windows.Forms.Button();
            this.logo1_pb = new System.Windows.Forms.PictureBox();
            this.OldNewbtn_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo1_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // OldNewbtn_panel
            // 
            this.OldNewbtn_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OldNewbtn_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.OldNewbtn_panel.Controls.Add(this.NewPatient_btn);
            this.OldNewbtn_panel.Controls.Add(this.OldPatient_btn);
            this.OldNewbtn_panel.Controls.Add(this.BackPF_btn);
            this.OldNewbtn_panel.Controls.Add(this.logo1_pb);
            this.OldNewbtn_panel.Location = new System.Drawing.Point(1, 1);
            this.OldNewbtn_panel.Name = "OldNewbtn_panel";
            this.OldNewbtn_panel.Size = new System.Drawing.Size(1003, 581);
            this.OldNewbtn_panel.TabIndex = 4;
            // 
            // NewPatient_btn
            // 
            this.NewPatient_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPatient_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(235)))));
            this.NewPatient_btn.Font = new System.Drawing.Font("Rockwell Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPatient_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NewPatient_btn.Location = new System.Drawing.Point(531, 87);
            this.NewPatient_btn.Name = "NewPatient_btn";
            this.NewPatient_btn.Size = new System.Drawing.Size(394, 195);
            this.NewPatient_btn.TabIndex = 1;
            this.NewPatient_btn.Text = "New Patient";
            this.NewPatient_btn.UseVisualStyleBackColor = false;
            this.NewPatient_btn.Click += new System.EventHandler(this.NewPatient_btn_Click);
            // 
            // OldPatient_btn
            // 
            this.OldPatient_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OldPatient_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(235)))));
            this.OldPatient_btn.Font = new System.Drawing.Font("Rockwell Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPatient_btn.Location = new System.Drawing.Point(531, 288);
            this.OldPatient_btn.Name = "OldPatient_btn";
            this.OldPatient_btn.Size = new System.Drawing.Size(394, 195);
            this.OldPatient_btn.TabIndex = 2;
            this.OldPatient_btn.Text = "Old Patient";
            this.OldPatient_btn.UseVisualStyleBackColor = false;
            // 
            // BackPF_btn
            // 
            this.BackPF_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackPF_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(235)))));
            this.BackPF_btn.Font = new System.Drawing.Font("Rockwell Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackPF_btn.Location = new System.Drawing.Point(48, 452);
            this.BackPF_btn.Name = "BackPF_btn";
            this.BackPF_btn.Size = new System.Drawing.Size(214, 118);
            this.BackPF_btn.TabIndex = 3;
            this.BackPF_btn.Text = "Back";
            this.BackPF_btn.UseVisualStyleBackColor = false;
            // 
            // logo1_pb
            // 
            this.logo1_pb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo1_pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo1_pb.BackgroundImage")));
            this.logo1_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo1_pb.Location = new System.Drawing.Point(15, 51);
            this.logo1_pb.Name = "logo1_pb";
            this.logo1_pb.Size = new System.Drawing.Size(536, 395);
            this.logo1_pb.TabIndex = 0;
            this.logo1_pb.TabStop = false;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OldNewbtn_panel);
            this.Name = "Patient";
            this.Size = new System.Drawing.Size(1003, 581);
            this.OldNewbtn_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo1_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OldNewbtn_panel;
        private System.Windows.Forms.Button NewPatient_btn;
        private System.Windows.Forms.Button OldPatient_btn;
        private System.Windows.Forms.Button BackPF_btn;
        private System.Windows.Forms.PictureBox logo1_pb;
    }
}
