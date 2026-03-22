using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public static class AppState
    {
        
            // PATIENT INFORMATION
            public static string PatientName { get; set; } = string.Empty;
            public static string PatientID { get; set; } = string.Empty;
            public static string PatientGender { get; set; } = string.Empty;
            public static string PatientCpnum { get; set; } = string.Empty;
            public static string PatientAddress { get; set; } = string.Empty;
            public static string PatientDentist { get; set; } = string.Empty;

            // Emergency Contact Person
            public static string EmergencyName { get; set; }
            public static string EmergencyNumber { get; set; }



            // STATUS
            public static bool IsOldPatient = false;

            // SERVICES
            public static string SelectedService;

            // QUEUE
            public static int QueueNumber = 0;
            private static int _queueNumber = 0;
            internal static bool IsoldPatient;

            // Queue auto increment
            public static int QueueNumberAuto
            {
                get { return _queueNumber; }
                set { _queueNumber = value; }
            }

            public static int NextQueueNumber()
            {
                _queueNumber++;
                return _queueNumber;
            }

            // HELPERS
            public static bool HasPatient()
            {
                return !string.IsNullOrWhiteSpace(PatientName);
            }

            public static bool HasService()
            {
                return !string.IsNullOrWhiteSpace(SelectedService);
            }

            // RESET TO FORM 1
            public static void Reset()
            {
                PatientName = null;
                PatientID = null;
                PatientGender = null;
                PatientCpnum = null;
                PatientAddress = null;

                EmergencyName = null;
                EmergencyNumber = null;

                SelectedService = null;
                IsOldPatient = false;
            }
    }
}
