namespace Clinic
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Main_panel = new System.Windows.Forms.Panel();
            this.Apt_panel = new System.Windows.Forms.Panel();
            this.Appointment_lbl = new System.Windows.Forms.Label();
            this.Serlbl_panel = new System.Windows.Forms.Panel();
            this.Service_lbl = new System.Windows.Forms.Label();
            this.Menu_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.Appointment_panel = new System.Windows.Forms.Panel();
            this.Service_panel = new System.Windows.Forms.Panel();
            this.LogoTitile_panel = new System.Windows.Forms.Panel();
            this.Menulbl = new System.Windows.Forms.Label();
            this.logo_pb = new System.Windows.Forms.PictureBox();
            this.Main_panel.SuspendLayout();
            this.Apt_panel.SuspendLayout();
            this.Serlbl_panel.SuspendLayout();
            this.Menu_tlp.SuspendLayout();
            this.LogoTitile_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_panel
            // 
            this.Main_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Main_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.Main_panel.Controls.Add(this.Apt_panel);
            this.Main_panel.Controls.Add(this.Serlbl_panel);
            this.Main_panel.Controls.Add(this.Menu_tlp);
            this.Main_panel.Controls.Add(this.LogoTitile_panel);
            this.Main_panel.Controls.Add(this.logo_pb);
            this.Main_panel.Location = new System.Drawing.Point(0, 0);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(1003, 581);
            this.Main_panel.TabIndex = 0;
            // 
            // Apt_panel
            // 
            this.Apt_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Apt_panel.Controls.Add(this.Appointment_lbl);
            this.Apt_panel.Location = new System.Drawing.Point(243, 247);
            this.Apt_panel.Name = "Apt_panel";
            this.Apt_panel.Size = new System.Drawing.Size(258, 48);
            this.Apt_panel.TabIndex = 2;
            // 
            // Appointment_lbl
            // 
            this.Appointment_lbl.AutoSize = true;
            this.Appointment_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Appointment_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appointment_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Appointment_lbl.Location = new System.Drawing.Point(13, -1);
            this.Appointment_lbl.Name = "Appointment_lbl";
            this.Appointment_lbl.Size = new System.Drawing.Size(232, 47);
            this.Appointment_lbl.TabIndex = 3;
            this.Appointment_lbl.Text = "Appointment";
            // 
            // Serlbl_panel
            // 
            this.Serlbl_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Serlbl_panel.Controls.Add(this.Service_lbl);
            this.Serlbl_panel.Location = new System.Drawing.Point(602, 246);
            this.Serlbl_panel.Name = "Serlbl_panel";
            this.Serlbl_panel.Size = new System.Drawing.Size(156, 48);
            this.Serlbl_panel.TabIndex = 4;
            // 
            // Service_lbl
            // 
            this.Service_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Service_lbl.AutoSize = true;
            this.Service_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Service_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Service_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Service_lbl.Location = new System.Drawing.Point(14, 2);
            this.Service_lbl.Name = "Service_lbl";
            this.Service_lbl.Size = new System.Drawing.Size(134, 47);
            this.Service_lbl.TabIndex = 3;
            this.Service_lbl.Text = "Service";
            // 
            // Menu_tlp
            // 
            this.Menu_tlp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Menu_tlp.ColumnCount = 2;
            this.Menu_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.91361F));
            this.Menu_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.33186F));
            this.Menu_tlp.Controls.Add(this.Appointment_panel, 0, 0);
            this.Menu_tlp.Controls.Add(this.Service_panel, 1, 0);
            this.Menu_tlp.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.Menu_tlp.Location = new System.Drawing.Point(152, 267);
            this.Menu_tlp.Name = "Menu_tlp";
            this.Menu_tlp.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.Menu_tlp.RowCount = 1;
            this.Menu_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Menu_tlp.Size = new System.Drawing.Size(724, 314);
            this.Menu_tlp.TabIndex = 0;
            // 
            // Appointment_panel
            // 
            this.Appointment_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Appointment_panel.BackgroundImage")));
            this.Appointment_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Appointment_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Appointment_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Appointment_panel.Location = new System.Drawing.Point(60, 30);
            this.Appointment_panel.Margin = new System.Windows.Forms.Padding(10);
            this.Appointment_panel.Name = "Appointment_panel";
            this.Appointment_panel.Size = new System.Drawing.Size(313, 254);
            this.Appointment_panel.TabIndex = 1;
            this.Appointment_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Appointment_panel_Paint);
            // 
            // Service_panel
            // 
            this.Service_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Service_panel.BackgroundImage")));
            this.Service_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Service_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Service_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Service_panel.Location = new System.Drawing.Point(393, 30);
            this.Service_panel.Margin = new System.Windows.Forms.Padding(10);
            this.Service_panel.Name = "Service_panel";
            this.Service_panel.Size = new System.Drawing.Size(271, 254);
            this.Service_panel.TabIndex = 2;
            this.Service_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Service_panel_Paint);
            // 
            // LogoTitile_panel
            // 
            this.LogoTitile_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogoTitile_panel.Controls.Add(this.Menulbl);
            this.LogoTitile_panel.Location = new System.Drawing.Point(376, 29);
            this.LogoTitile_panel.Name = "LogoTitile_panel";
            this.LogoTitile_panel.Size = new System.Drawing.Size(421, 128);
            this.LogoTitile_panel.TabIndex = 1;
            this.LogoTitile_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.LogoTitile_panel_Paint);
            // 
            // Menulbl
            // 
            this.Menulbl.AutoSize = true;
            this.Menulbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Menulbl.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menulbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Menulbl.Location = new System.Drawing.Point(18, 28);
            this.Menulbl.Name = "Menulbl";
            this.Menulbl.Size = new System.Drawing.Size(385, 86);
            this.Menulbl.TabIndex = 0;
            this.Menulbl.Text = "Clinic Portal";
            // 
            // logo_pb
            // 
            this.logo_pb.Image = ((System.Drawing.Image)(resources.GetObject("logo_pb.Image")));
            this.logo_pb.Location = new System.Drawing.Point(56, 8);
            this.logo_pb.Name = "logo_pb";
            this.logo_pb.Size = new System.Drawing.Size(314, 252);
            this.logo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_pb.TabIndex = 1;
            this.logo_pb.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Main_panel);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(1003, 581);
            this.Main_panel.ResumeLayout(false);
            this.Apt_panel.ResumeLayout(false);
            this.Apt_panel.PerformLayout();
            this.Serlbl_panel.ResumeLayout(false);
            this.Serlbl_panel.PerformLayout();
            this.Menu_tlp.ResumeLayout(false);
            this.LogoTitile_panel.ResumeLayout(false);
            this.LogoTitile_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.TableLayoutPanel Menu_tlp;
        private System.Windows.Forms.Panel Appointment_panel;
        private System.Windows.Forms.Panel Service_panel;
        private System.Windows.Forms.Panel LogoTitile_panel;
        private System.Windows.Forms.Label Menulbl;
        private System.Windows.Forms.PictureBox logo_pb;
        private System.Windows.Forms.Panel Serlbl_panel;
        private System.Windows.Forms.Label Service_lbl;
        private System.Windows.Forms.Panel Apt_panel;
        private System.Windows.Forms.Label Appointment_lbl;
    }
}
