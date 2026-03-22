using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ── Create database and tables if they don't exist ─────
            bool dbReady = DatabaseSetup.Initialize();

            if (!dbReady)
            {
                // Database setup failed — show message and exit
                MessageBox.Show(
                    "The application could not connect to the database.\n\n" +
                    "Please make sure:\n" +
                    "1. MySQL is running\n" +
                    "2. Your password is correct in DatabaseSetup.cs\n" +
                    "3. The MySQL server is accessible at localhost",
                    "Startup Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return; // ← exit app if DB is not available
            }

            // ── All good — start the application ───────────────────
            Application.Run(new kiosk());
        }
    }
}