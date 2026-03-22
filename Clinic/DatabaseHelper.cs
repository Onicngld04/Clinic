using System;
using MySql.Data.MySqlClient;

namespace Clinic
{
    public static class DatabaseHelper
    {
        private const string _connectionString =
            "server=localhost;" +
            "database=clinic_db;" +
            "uid=root;" +
            "password=;";  // ← put your MySQL password here

        public static string GetConnectionString() => _connectionString;

        private static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(_connectionString);
            conn.Open();
            return conn;
        }

        // ══════════════════════════════════════════════════════
        //  GENERATE PATIENT ID
        //  Format: P-BIRTHYEAR-XXXX  e.g. P-1995-0001
        //  Uses the patient's birth year instead of current year
        // ══════════════════════════════════════════════════════
        public static string GeneratePatientID(int birthYear)
        {
            string prefix = $"P-{birthYear}-";
            int nextNum = 1;

            try
            {
                using (var conn = GetConnection())
                {
                    string query = @"
                        SELECT patient_id
                        FROM   patients
                        WHERE  patient_id LIKE @prefix
                        ORDER  BY patient_id DESC
                        LIMIT  1";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@prefix", prefix + "%");

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string lastID = result.ToString();
                            string numPart = lastID.Substring(prefix.Length);

                            if (int.TryParse(numPart, out int lastNum))
                                nextNum = lastNum + 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    $"Error generating Patient ID:\n{ex.Message}",
                    "Database Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
            }

            // Format: P-1995-0001
            return $"{prefix}{nextNum:D4}";
        }

        // ══════════════════════════════════════════════════════
        //  SAVE PATIENT
        // ══════════════════════════════════════════════════════
        public static bool SavePatient(
            string patientID,
            string fullName,
            string gender,
            string contactNumber,
            string address,
            string emergencyName,
            string emergencyNumber)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    string query = @"
                        INSERT INTO patients
                            (patient_id, full_name, gender, contact_number,
                             address, emergency_name, emergency_number)
                        VALUES
                            (@patientID, @fullName, @gender, @contactNumber,
                             @address, @emergencyName, @emergencyNumber)";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@patientID", patientID);
                        cmd.Parameters.AddWithValue("@fullName", fullName);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@emergencyName", emergencyName);
                        cmd.Parameters.AddWithValue("@emergencyNumber", emergencyNumber);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    $"Error saving patient:\n{ex.Message}",
                    "Database Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);

                return false;
            }
        }

        // ══════════════════════════════════════════════════════
        //  PATIENT EXISTS
        // ══════════════════════════════════════════════════════
        public static bool PatientExists(string patientID)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM patients WHERE patient_id = @patientID";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@patientID", patientID);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    $"Error checking patient:\n{ex.Message}",
                    "Database Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);

                return false;
            }
        }

        // ══════════════════════════════════════════════════════
        //  GET PATIENT NAME
        // ══════════════════════════════════════════════════════
        public static string GetPatientName(string patientID)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    string query = "SELECT full_name FROM patients WHERE patient_id = @patientID";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@patientID", patientID);

                        object result = cmd.ExecuteScalar();
                        return result != null ? result.ToString() : null;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    $"Error getting patient name:\n{ex.Message}",
                    "Database Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);

                return null;
            }
        }

        // ══════════════════════════════════════════════════════
        //  TEST CONNECTION
        // ══════════════════════════════════════════════════════
        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}