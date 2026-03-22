using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clinic
{
    public static class DatabaseSetup
    {
        // ══════════════════════════════════════════════════════
        //  Connection string WITHOUT a database selected
        //  Used only to CREATE the database if it doesn't exist
        // ══════════════════════════════════════════════════════
        private const string ServerConnectionString =
            "server=localhost;" +
            "uid=root;" +
            "password=;";  // ← put your MySQL password here

        // ══════════════════════════════════════════════════════
        //  Run on app startup — creates DB and tables if needed
        // ══════════════════════════════════════════════════════
        public static bool Initialize()
        {
            try
            {
                // Step 1 — Create the database if it doesn't exist
                CreateDatabase();

                // Step 2 — Create all tables if they don't exist
                CreateTables();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Database setup failed:\n\n{ex.Message}\n\n" +
                    $"Please make sure MySQL is running and your password is correct in DatabaseSetup.cs",
                    "Database Setup Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }

        // ── Step 1: Create the database ───────────────────────
        private static void CreateDatabase()
        {
            using (var conn = new MySqlConnection(ServerConnectionString))
            {
                conn.Open();

                string sql = @"
                    CREATE DATABASE IF NOT EXISTS clinic_db
                    CHARACTER SET utf8mb4
                    COLLATE utf8mb4_unicode_ci;";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ── Step 2: Create all tables ─────────────────────────
        private static void CreateTables()
        {
            using (var conn = new MySqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();

                // ── patients table ─────────────────────────────
                string createPatients = @"
                    CREATE TABLE IF NOT EXISTS patients (
                        patient_id          VARCHAR(20)     NOT NULL PRIMARY KEY,
                        full_name           VARCHAR(100)    NOT NULL,
                        gender              VARCHAR(10)     NOT NULL,
                        contact_number      VARCHAR(11)     NOT NULL,
                        address             VARCHAR(255)    NOT NULL,
                        emergency_name      VARCHAR(100)    NOT NULL,
                        emergency_number    VARCHAR(11)     NOT NULL,
                        date_registered     DATETIME        NOT NULL DEFAULT CURRENT_TIMESTAMP
                    );";

                using (var cmd = new MySqlCommand(createPatients, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
