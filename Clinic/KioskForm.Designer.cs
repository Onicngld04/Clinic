namespace Clinic
{
    partial class kiosk
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kiosk));
            this.Welcome_panel = new System.Windows.Forms.Panel();
            this.WCM_panel = new System.Windows.Forms.Panel();
            this.Click_lbl = new System.Windows.Forms.Label();
            this.Intro_panel = new System.Windows.Forms.Panel();
            this.Gentel_lbl = new System.Windows.Forms.Label();
            this.Welcome_lbl = new System.Windows.Forms.Label();
            this.Logo1_pb = new System.Windows.Forms.PictureBox();
            this.panelWelcome_Click = new System.Windows.Forms.Panel();
            this.Welcome_panel.SuspendLayout();
            this.WCM_panel.SuspendLayout();
            this.Intro_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo1_pb)).BeginInit();
            this.panelWelcome_Click.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome_panel
            // 
            this.Welcome_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Welcome_panel.BackColor = System.Drawing.Color.White;
            this.Welcome_panel.Controls.Add(this.WCM_panel);
            this.Welcome_panel.Location = new System.Drawing.Point(-2, -1);
            this.Welcome_panel.Name = "Welcome_panel";
            this.Welcome_panel.Size = new System.Drawing.Size(989, 543);
            this.Welcome_panel.TabIndex = 5;
            this.Welcome_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Welcome_panel_Paint);
            // 
            // WCM_panel
            // 
            this.WCM_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WCM_panel.Controls.Add(this.Logo1_pb);
            this.WCM_panel.Controls.Add(this.Intro_panel);
            this.WCM_panel.Controls.Add(this.Click_lbl);
            this.WCM_panel.Location = new System.Drawing.Point(0, 0);
            this.WCM_panel.Name = "WCM_panel";
            this.WCM_panel.Size = new System.Drawing.Size(985, 536);
            this.WCM_panel.TabIndex = 4;
            this.WCM_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.WCM_panel_Paint);
            // 
            // Click_lbl
            // 
            this.Click_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Click_lbl.AutoSize = true;
            this.Click_lbl.BackColor = System.Drawing.Color.White;
            this.Click_lbl.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Click_lbl.ForeColor = System.Drawing.Color.Black;
            this.Click_lbl.Location = new System.Drawing.Point(432, 496);
            this.Click_lbl.Name = "Click_lbl";
            this.Click_lbl.Size = new System.Drawing.Size(161, 19);
            this.Click_lbl.TabIndex = 6;
            this.Click_lbl.Text = "click anywhere to continue...";
            this.Click_lbl.Click += new System.EventHandler(this.Click_Click);
            // 
            // Intro_panel
            // 
            this.Intro_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Intro_panel.Controls.Add(this.Gentel_lbl);
            this.Intro_panel.Controls.Add(this.Welcome_lbl);
            this.Intro_panel.Location = new System.Drawing.Point(221, 359);
            this.Intro_panel.Name = "Intro_panel";
            this.Intro_panel.Size = new System.Drawing.Size(569, 137);
            this.Intro_panel.TabIndex = 5;
            this.Intro_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Gentel_lbl
            // 
            this.Gentel_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Gentel_lbl.AutoSize = true;
            this.Gentel_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Gentel_lbl.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gentel_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Gentel_lbl.Location = new System.Drawing.Point(83, 85);
            this.Gentel_lbl.Name = "Gentel_lbl";
            this.Gentel_lbl.Size = new System.Drawing.Size(452, 38);
            this.Gentel_lbl.TabIndex = 3;
            this.Gentel_lbl.Text = "Gentle care for every smile.";
            this.Gentel_lbl.Click += new System.EventHandler(this.Gentel_Click);
            // 
            // Welcome_lbl
            // 
            this.Welcome_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Welcome_lbl.AutoSize = true;
            this.Welcome_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.Welcome_lbl.Font = new System.Drawing.Font("Rockwell Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Welcome_lbl.Location = new System.Drawing.Point(4, 20);
            this.Welcome_lbl.Name = "Welcome_lbl";
            this.Welcome_lbl.Size = new System.Drawing.Size(563, 56);
            this.Welcome_lbl.TabIndex = 2;
            this.Welcome_lbl.Text = "Welcome to MedCore Dental Clinic";
            this.Welcome_lbl.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // Logo1_pb
            // 
            this.Logo1_pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Logo1_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo1_pb.Image = ((System.Drawing.Image)(resources.GetObject("Logo1_pb.Image")));
            this.Logo1_pb.Location = new System.Drawing.Point(199, -35);
            this.Logo1_pb.Name = "Logo1_pb";
            this.Logo1_pb.Size = new System.Drawing.Size(610, 344);
            this.Logo1_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo1_pb.TabIndex = 3;
            this.Logo1_pb.TabStop = false;
            this.Logo1_pb.Click += new System.EventHandler(this.Logo1_pb_Click);
            // 
            // panelWelcome_Click
            // 
            this.panelWelcome_Click.BackColor = System.Drawing.Color.White;
            this.panelWelcome_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelWelcome_Click.Controls.Add(this.Welcome_panel);
            this.panelWelcome_Click.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWelcome_Click.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome_Click.Name = "panelWelcome_Click";
            this.panelWelcome_Click.Size = new System.Drawing.Size(987, 542);
            this.panelWelcome_Click.TabIndex = 4;
            this.panelWelcome_Click.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWelcome_Click_Paint);
            // 
            // kiosk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 542);
            this.ControlBox = false;
            this.Controls.Add(this.panelWelcome_Click);
            this.Name = "kiosk";
            this.Text = "Kiosk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.kiosk_Load);
            this.Welcome_panel.ResumeLayout(false);
            this.WCM_panel.ResumeLayout(false);
            this.WCM_panel.PerformLayout();
            this.Intro_panel.ResumeLayout(false);
            this.Intro_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo1_pb)).EndInit();
            this.panelWelcome_Click.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Welcome_panel;
        private System.Windows.Forms.PictureBox Logo1_pb;
        private System.Windows.Forms.Label Welcome_lbl;
        private System.Windows.Forms.Label Gentel_lbl;
        private System.Windows.Forms.Panel panelWelcome_Click;
        private System.Windows.Forms.Panel WCM_panel;
        private System.Windows.Forms.Panel Intro_panel;
        private System.Windows.Forms.Label Click_lbl;
    }
}

