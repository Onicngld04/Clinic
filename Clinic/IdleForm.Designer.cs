namespace Clinic
{
    partial class IdleForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdleForm));
            this.img1_pb = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.img1_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // img1_pb
            // 
            this.img1_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img1_pb.Image = ((System.Drawing.Image)(resources.GetObject("img1_pb.Image")));
            this.img1_pb.Location = new System.Drawing.Point(0, 0);
            this.img1_pb.Name = "img1_pb";
            this.img1_pb.Size = new System.Drawing.Size(1003, 581);
            this.img1_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1_pb.TabIndex = 0;
            this.img1_pb.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            // 
            // IdleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.img1_pb);
            this.Name = "IdleForm";
            this.Size = new System.Drawing.Size(1003, 581);
            ((System.ComponentModel.ISupportInitialize)(this.img1_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img1_pb;
        private System.Windows.Forms.Timer timer1;
    }
}
