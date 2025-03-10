using System;
using System.Collections.Generic;

// Abstract class representing a patient
abstract class Patient
{
    public int PatientId { get; private set; }
    public string Name { get; private set; }
    public int Age { get; private set; }
    
    protected string Diagnosis { get; set; }
    protected string MedicalHistory { get; set; } 

    public Patient(int patientId, string name, int age)
    {
        PatientId = patientId;
        Name = name;
        Age = age;
    }

    public abstract double CalculateBill();

    public void GetPatientDetails()
    {
        Console.WriteLine($"Patient ID: {PatientId}, Name: {Name}, Age: {Age}");
    }
}
interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}
class InPatient : Patient, IMedicalRecord
{
    private double dailyCharge;
    private int numberOfDays;
    private List<string> medicalRecords = new List<string>();

    public InPatient(int patientId, string name, int age, double dailyCharge, int numberOfDays)
        : base(patientId, name, age)
    {
        this.dailyCharge = dailyCharge;
        this.numberOfDays = numberOfDays;
    }

    public override double CalculateBill()
    {
        return dailyCharge * numberOfDays;
    }

    public void AddRecord(string record)
    {
        medicalRecords.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records:");
        foreach (var record in medicalRecords)
        {
            Console.WriteLine(record);
        }
    }
}
class OutPatient : Patient, IMedicalRecord
{
    private double consultationFee;
    private List<string> medicalRecords = new List<string>();

    public OutPatient(int patientId, string name, int age, double consultationFee)
        : base(patientId, name, age)
    {
        this.consultationFee = consultationFee;
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }

    public void AddRecord(string record)
    {
        medicalRecords.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records:");
        foreach (var record in medicalRecords)
        {
            Console.WriteLine(record);
        }
    }
}

// Program execution
class Program
{
    static void Main()
    {
        Patient inPatient = new InPatient(101, "Alice", 30, 500, 5);
        inPatient.GetPatientDetails();
        Console.WriteLine($"Total Bill: {inPatient.CalculateBill():C}");

        Console.WriteLine();

        OutPatient outPatient = new OutPatient(102, "Bob", 40, 200);
        outPatient.GetPatientDetails();
        outPatient.AddRecord("Routine checkup completed.");
        outPatient.ViewRecords();
        Console.WriteLine($"Total Bill: {outPatient.CalculateBill():C}");
    }
}
