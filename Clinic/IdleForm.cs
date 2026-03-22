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
    public partial class IdleForm : UserControl
    {
        private kiosk mainForm;

        private List<string> imagePaths;
        private int currentImage = 0;

        public IdleForm(kiosk form)
        {
            InitializeComponent();
            mainForm = form;

            // CLICK EVENT (exit idle)
            img1_pb.Click += ExitIdle;
            this.Click += ExitIdle;

            // connect timer
            timer1.Tick += Timer1_Tick;
        }

        private void IdleForm_Load(object sender, EventArgs e)
        {
            // GET PROJECT PATH (bin/Debug)
            string basePath = Application.StartupPath;

            // LIST OF IMAGES
            imagePaths = new List<string>()
            {
                Path.Combine(basePath, "img1.jpg"),
                Path.Combine(basePath, "img2.jpg"),
                Path.Combine(basePath, "img3.png"),
                Path.Combine(basePath, "img4.jpg"),
                Path.Combine(basePath, "img5.png")
            };

            // CHECK images exist
            if (imagePaths.Count == 0)
            {
                MessageBox.Show("No images found.");
                return;
            }

            // LOAD FIRST IMAGE
            currentImage = 0;
            LoadImage();

            // TIMER SETTINGS
            timer1.Interval = 3000; // 3 seconds
            timer1.Start();

            // UI SETTINGS
            img1_pb.Dock = DockStyle.Fill;
            img1_pb.SizeMode = PictureBoxSizeMode.Zoom;
            img1_pb.Cursor = Cursors.Hand;
            img1_pb.BringToFront();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (imagePaths == null || imagePaths.Count == 0)
                return;

            // LOOPING FIX
            currentImage = (currentImage + 1) % imagePaths.Count;

            LoadImage();
        }

        private void LoadImage()
        {
            try
            {
                string path = imagePaths[currentImage];

                if (!File.Exists(path))
                    return;

                // Dispose old image safely
                if (img1_pb.Image != null)
                {
                    var oldImage = img1_pb.Image;
                    img1_pb.Image = null;
                    oldImage.Dispose();
                }

                // Load new image
                img1_pb.Image = Image.FromFile(path);
            }
            catch
            {
                // skip error to continue slideshow
            }
        }

        private void ExitIdle(object sender, EventArgs e)
        {
            timer1.Stop();
            mainForm.ShowKioskMainForm();
        }

    }
}
