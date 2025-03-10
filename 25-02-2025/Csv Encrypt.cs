using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
class CSVEncryptDecrypt
{
// Encryption Key (Keep it secret)
private static readonly string encryptionKey =

"YourStrongPassword123!";
public static void Print()
{
string csvFilePath = "Employee_Encrypted.csv";
string decryptedCsvFilePath = "Employee_Decrypted.csv";

List<Employee> employees = new List<Employee>
{
new Employee(101, "Somesh", "IT", "somesh@example.com",

70000),

new Employee(102, "Bengoli", "HR", "Sona@example.com",

65000),

new Employee(103, "Yash", "Finance", "yash@example.com",

80000),

new Employee(104, "Shubham", "Marketing",

"shubham@example.com", 60000)
};
// Encrypt and write CSV
EncryptAndWriteCSV(csvFilePath, employees);
// Read and Decrypt CSV
DecryptAndReadCSV(csvFilePath, decryptedCsvFilePath);
}
// Encrypt and write employee data to CSV
static void EncryptAndWriteCSV(string filePath, List<Employee>
employees)
{
using (StreamWriter writer = new StreamWriter(filePath))
{
writer.WriteLine("Employee
ID,Name,Department,Email,Salary");
foreach (var emp in employees)
{
string encryptedEmail = Encrypt(emp.Email);
string encryptedSalary = Encrypt(emp.Salary.ToString());

writer.WriteLine($"{emp.EmployeeID},{emp.Name},{emp.Department},{encrypt
edEmail},{encryptedSalary}");

}
}
Console.WriteLine($"Encrypted CSV file created: {filePath}");
}
// Read, decrypt, and write to a new CSV file
static void DecryptAndReadCSV(string inputFilePath, string
outputFilePath)
{
if (!File.Exists(inputFilePath))
{
Console.WriteLine("Error: Encrypted CSV file not found!");
return;
}
using (StreamReader reader = new StreamReader(inputFilePath))
using (StreamWriter writer = new StreamWriter(outputFilePath))
{
string header = reader.ReadLine();
writer.WriteLine(header); // Write header to new file
Console.WriteLine("\nDecrypted Records:");
Console.WriteLine(header);
string line;
while ((line = reader.ReadLine()) != null)
{
string[] values = line.Split(',');
if (values.Length >= 5)
{
string decryptedEmail = Decrypt(values[3]);
string decryptedSalary = Decrypt(values[4]);

writer.WriteLine($"{values[0]},{values[1]},{values[2]},{decryptedEmail},
{decryptedSalary}");
Console.WriteLine($"{values[0]},{values[1]},{values[2]},{decryptedEmail}
,{decryptedSalary}");
}
}
}

Console.WriteLine($"\nDecrypted CSV file created:
{outputFilePath}");
}
// AES Encryption
static string Encrypt(string text)
{
using (Aes aes = Aes.Create())
{
aes.Key =

Encoding.UTF8.GetBytes(encryptionKey.PadRight(32)); // 256-bit key

aes.IV = new byte[16]; // Zero IV
using (ICryptoTransform encryptor =

aes.CreateEncryptor(aes.Key, aes.IV))

{
byte[] inputBytes = Encoding.UTF8.GetBytes(text);
byte[] encryptedBytes =

encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
return Convert.ToBase64String(encryptedBytes);
}
}
}
// AES Decryption
static string Decrypt(string encryptedText)
{
using (Aes aes = Aes.Create())
{
aes.Key =

Encoding.UTF8.GetBytes(encryptionKey.PadRight(32));

aes.IV = new byte[16];
using (ICryptoTransform decryptor =

aes.CreateDecryptor(aes.Key, aes.IV))

{
byte[] encryptedBytes =
Convert.FromBase64String(encryptedText);
byte[] decryptedBytes =

decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

return Encoding.UTF8.GetString(decryptedBytes);
}
}

}
}
// Employee class
class Employee
{
public int EmployeeID { get; }
public string Name { get; }
public string Department { get; }
public string Email { get; }
public decimal Salary { get; }
public Employee(int id, string name, string department, string
email, decimal salary)
{
EmployeeID = id;
Name = name;
Department = department;
Email = email;
Salary = salary;
}
}