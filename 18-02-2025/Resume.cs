using System;
using System.Collections.Generic;
public abstract class JobRole
{
    public string RoleName { get; set; }
    public abstract void ScreenResume();
}
public class SoftwareEngineer : JobRole
{
    public SoftwareEngineer()
    {
        RoleName = "Software Engineer";
    }

    public override void ScreenResume()
    {
        Console.WriteLine("Screening resume for " + RoleName + ": Checking for programming skills, algorithms, and system design knowledge.");
    }
}
public class DataScientist : JobRole
{
    public DataScientist()
    {
        RoleName = "Data Scientist";
    }
    public override void ScreenResume()
    {
        Console.WriteLine("Screening resume for " + RoleName + ": Checking for data analysis, machine learning, and statistical modeling skills.");
    }
}
public class Resume<T> where T : JobRole
{
    private T _jobRole;
    public Resume(T jobRole)
    {
        _jobRole = jobRole;
    }
    public void Screen()
    {
        _jobRole.ScreenResume();
    }
}
public class ResumeScreeningSystem
{
    private List<JobRole> _jobRoles = new List<JobRole>();
    public void AddJobRole(JobRole jobRole)
    {
        _jobRoles.Add(jobRole);
        Console.WriteLine("Added job role: " + jobRole.RoleName);
    }
    public void ScreenAllResumes()
    {
        Console.WriteLine("\nScreening all resumes:");
        foreach (var jobRole in _jobRoles)
        {
            jobRole.ScreenResume();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        var softwareEngineer = new SoftwareEngineer();
        var dataScientist = new DataScientist();
        var resume1 = new Resume<SoftwareEngineer>(softwareEngineer);
        var resume2 = new Resume<DataScientist>(dataScientist);
        resume1.Screen();
        resume2.Screen();
        var screeningSystem = new ResumeScreeningSystem();
        screeningSystem.AddJobRole(softwareEngineer);
        screeningSystem.AddJobRole(dataScientist);
        screeningSystem.ScreenAllResumes();
    }
}