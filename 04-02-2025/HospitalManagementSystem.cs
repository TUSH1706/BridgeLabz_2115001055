using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Patient
    {
        public static string HospitalName = "City Care Hospital";
        private static int totalPatients = 0;

        // Readonly variable to uniquely identify each patient
        public readonly int PatientID;
        private static int patientCounter = 1000; // Unique ID starts from 1000

        private string Name;
        private int Age;
        private string Ailment;

        public Patient(string name, int age, string ailment)
        {
            this.PatientID = ++patientCounter; // Assign unique patient ID
            this.Name = name;
            this.Age = age;
            this.Ailment = ailment;
            totalPatients++;
        }

        // Static method to get the total number of admitted patients
        public static void GetTotalPatients()
        {
            Console.WriteLine($"Total Patients Admitted: {totalPatients}");
        }


        public string GetPatientDetails()
        {
            return $"Patient ID: {PatientID}\nName: {Name}\nAge: {Age}\nAilment: {Ailment}\nHospital: {HospitalName}";
        }

        // Method to check if an object is of type Patient using 'is'
        public static void DisplayPatientDetails(object obj)
        {
            if (obj is Patient patient)
            {
                Console.WriteLine(patient.GetPatientDetails());
            }
            else
            {
                Console.WriteLine("The object is not a Patient.");
            }
        }
    }
}
