using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemAssociation
{
    public class Doctor
    {
        public string name;
        private List<Patient> patients;
        public Doctor(string name)
        {
            this.name = name;
            patients = new List<Patient>();
        }

        public void consult(Patient patient)
        {
            Console.WriteLine($"Doctor {name} is consulting with Patient {patient.name}. \nConsultation details:");
            patient.consultationHistory.Add($"Consultation with Dr. {name}");
            patients.Add(patient);
        }

        public void showConsultations()
        {
            Console.WriteLine($"Dr. {name}'s Consultation History:");
            foreach (var patient in patients)
            {
                Console.WriteLine($"  Patient: {patient.name}");
            }
        }


    }

    public class Patient
    {
        public string name;
        public List<string> consultationHistory;

        public Patient(string name)
        {
            this.name = name;
            consultationHistory = new List<string>();
        }

        public void showConsultationHistory()
        {
            Console.WriteLine($"Patient: {name}'s Consultation History:");
            foreach (var consultation in consultationHistory)
            {
                Console.WriteLine($"  {consultation}");
            }
        }

    }

    public class Hospital
    {
        public string name;

        private List<Doctor> doctors;
        public Hospital(string name)
        {
            this.name = name;
            doctors = new List<Doctor>();
        }

        public void addDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
        }

        public void showDoctors()
        {
            Console.WriteLine($"Hospital: {name} has the following doctors:");
            foreach (var doctor in doctors)
            {
                Console.WriteLine($"  Dr. {doctor.name}");
            }
        }

    }
}
