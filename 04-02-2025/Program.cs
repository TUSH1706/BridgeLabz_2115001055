using System;
using BankAccountSystem;
using EmployeeManagementSystem;
using HospitalManagementSystem;
using LibraryManagementSystem;
using ShoppingCartManagement;
using UniversityStudentManagement;
using VehicleRegistrationSystem;

class program
{
    public static void Main(string[] args)
    {
        //while (true)
        //{
        //    Console.WriteLine("\nChoose an option:");
        //    Console.WriteLine("1. Add Account");
        //    Console.WriteLine("2. Display Account Details");
        //    Console.WriteLine("3. Display Total Accounts");
        //    Console.WriteLine("4. Exit");

        //    Console.Write("Enter your choice: ");
        //    int choice;
        //    if (!int.TryParse(Console.ReadLine(), out choice))
        //    {
        //        Console.WriteLine("Invalid input. Please enter a number.");
        //        continue;
        //    }

        //    switch (choice)
        //    {
        //        case 1:
        //            BankSystem.AddAccount();
        //            break;
        //        case 2:
        //            BankSystem.DisplayAccount();
        //            break;
        //        case 3:
        //            Console.WriteLine("Total Accounts: " + BankSystem.GetTotalAccounts());
        //            break;
        //        case 4:
        //            Console.WriteLine("Exiting... Thank you!");
        //            return;
        //        default:
        //            Console.WriteLine("Invalid choice. Please try again.");
        //            break;

        //    }
        //}


        // Question No - 2
        //Book[] books = new Book[3];
        //int bookCount = 0;

        //Book.DisplayLibraryName();

        //while (true)
        //{
        //    Console.WriteLine("\nLibrary Management System");
        //    Console.WriteLine("1. Add a New Book");
        //    Console.WriteLine("2. Display Book Details");
        //    Console.WriteLine("3. Exit");
        //    Console.Write("Enter your choice: ");

        //    int choice = int.Parse(Console.ReadLine());

        //    switch (choice)
        //    {
        //        case 1:
        //            if (bookCount >= books.Length)
        //            {

        //                Console.WriteLine("Limit Exceed!!");
        //            }

        //            Console.Write("Enter Book Title: ");
        //            string title = Console.ReadLine();

        //            Console.Write("Enter Book Author: ");
        //            string author = Console.ReadLine();

        //            Console.Write("Enter Book ISBN: ");
        //            string isbn = Console.ReadLine();

        //            books[bookCount] = new Book(title, author, isbn);
        //            bookCount++;
        //            Console.WriteLine("Book added successfully!");
        //            break;

        //        case 2:
        //            Console.Write("Enter ISBN of the book to display details: ");
        //            string searchIsbn = Console.ReadLine();

        //            bool found = false;
        //            foreach (var book in books)
        //            {
        //                if (book != null && book.ISBN == searchIsbn)
        //                {
        //                    Book.DisplayBookDetails(book);
        //                    found = true;
        //                    break;
        //                }
        //            }
        //            if (!found)
        //            {
        //                Console.WriteLine("Book with the given ISBN not found.");
        //            }
        //            break;

        //        case 3:
        //            Console.WriteLine("Exiting... Thank you for using the Library Management System.");
        //            return;

        //        default:
        //            Console.WriteLine("Invalid choice. Please try again.");
        //            break;

        //    }
        //}



        // Question No -3
        //List<Employee> employees = new List<Employee>();

        //while (true)
        //{
        //    Console.WriteLine("\nEmployee Management System");
        //    Console.WriteLine("1. Add New Employee");
        //    Console.WriteLine("2. Display Employee Details");
        //    Console.WriteLine("3. Show Total Employees");
        //    Console.WriteLine("4. Exit");
        //    Console.Write("Enter your choice: ");

        //    if (!int.TryParse(Console.ReadLine(), out int choice))
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid number.");
        //        continue;
        //    }

        //    switch (choice)
        //    {
        //        case 1:
        //            // Adding a new employee
        //            Console.Write("Enter Employee Name: ");
        //            string name = Console.ReadLine();

        //            Console.Write("Enter Employee ID: ");
        //            if (!int.TryParse(Console.ReadLine(), out int id))
        //            {
        //                Console.WriteLine("Invalid ID. Please enter a numeric value.");
        //                continue;
        //            }

        //            Console.Write("Enter Employee Designation: ");
        //            string designation = Console.ReadLine();

        //            employees.Add(new Employee(name, id, designation));
        //            Console.WriteLine("Employee added successfully!");
        //            break;

        //        case 2:
        //            // Display employee details
        //            Console.Write("Enter Employee ID to search: ");
        //            if (!int.TryParse(Console.ReadLine(), out int searchId))
        //            {
        //                Console.WriteLine("Invalid ID format.");
        //                continue;
        //            }
        //            Employee foundEmployee = employees.Find(emp => emp.Id == searchId);
        //            if (foundEmployee != null)
        //            {
        //                Employee.DisplayEmployeeDetails(foundEmployee);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Employee with the given ID not found.");
        //            }
        //            break;

        //        case 3:
        //            Employee.DisplayTotalEmployees();
        //            break;

        //        case 4:
        //            Console.WriteLine("Exiting... Thank you for using the Employee Management System.");
        //            return;

        //        default:
        //            Console.WriteLine("Invalid choice. Please try again.");
        //            break;
        //    }
        //}



        // QUESTION NO-4
        //List<Product> cart = new List<Product>();

        //while (true)
        //{
        //    Console.WriteLine("\nShopping Cart System");
        //    Console.WriteLine("1. Add New Product");
        //    Console.WriteLine("2. Display Product Details");
        //    Console.WriteLine("3. Update Discount");
        //    Console.WriteLine("4. Exit");
        //    Console.Write("Enter your choice: ");

        //    if (!int.TryParse(Console.ReadLine(), out int choice))
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid number.");
        //        continue;
        //    }

        //    switch (choice)
        //    {
        //        case 1:
        //            Console.Write("Enter Product Name: ");
        //            string productName = Console.ReadLine();

        //            Console.Write("Enter Product Price: ");
        //            if (!double.TryParse(Console.ReadLine(), out double price) || price <= 0)
        //            {
        //                Console.WriteLine("Invalid price. Please enter a valid number.");
        //                continue;
        //            }

        //            Console.Write("Enter Product Quantity: ");
        //            if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
        //            {
        //                Console.WriteLine("Invalid quantity. Please enter a positive integer.");
        //                continue;
        //            }

        //            cart.Add(new Product(productName, price, quantity));
        //            Console.WriteLine("Product added to cart successfully!");
        //            break;

        //        case 2:
        //            // Display product details
        //            Console.Write("Enter Product ID to search: ");
        //            if (!int.TryParse(Console.ReadLine(), out int searchId))
        //            {
        //                Console.WriteLine("Invalid ID format.");
        //                continue;
        //            }

        //            Product foundProduct = cart.Find(p => p.ProductID == searchId);
        //            if (foundProduct != null)
        //            {
        //                Product.DisplayProductDetails(foundProduct);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Product with the given ID not found.");
        //            }
        //            break;

        //        case 3:
        //            // Update discount
        //            Console.Write("Enter new discount percentage: ");
        //            if (!double.TryParse(Console.ReadLine(), out double newDiscount) || newDiscount < 0 || newDiscount > 100)
        //            {
        //                Console.WriteLine("Invalid discount percentage. Please enter a number between 0 and 100.");
        //                continue;
        //            }

        //            Product.UpdateDiscount(newDiscount);
        //            break;

        //        case 4:
        //            // Exit the program
        //            Console.WriteLine("Exiting... Thank you for using the Shopping Cart System.");
        //            return;

        //        default:
        //            Console.WriteLine("Invalid choice. Please try again.");
        //            break;
        //    }
        //}


        // QUESTION NO - 5

        //List<Student> students = new List<Student>();
        //while (true)
        //{
        //    Console.WriteLine("\nUniversity Student Management System");
        //    Console.WriteLine("1. Enroll New Student");
        //    Console.WriteLine("2. Display Student Details");
        //    Console.WriteLine("3. Update Student Grade");
        //    Console.WriteLine("4. Display Total Students");
        //    Console.WriteLine("5. Exit");
        //    Console.Write("Enter your choice: ");

        //    if (!int.TryParse(Console.ReadLine(), out int choice))
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid number.");
        //        continue;
        //    }


        //    switch (choice)
        //    {
        //        case 1:
        //            // Enroll a new student
        //            Console.Write("Enter Student Name: ");
        //            string name = Console.ReadLine();

        //            Console.Write("Enter Student Grade: ");
        //            string grade = Console.ReadLine();

        //            students.Add(new Student(name, grade));
        //            Console.WriteLine("Student enrolled successfully!");
        //            break;

        //        case 2:
        //            // Display student details
        //            Console.Write("Enter Roll Number to search: ");
        //            if (!int.TryParse(Console.ReadLine(), out int searchRoll))
        //            {
        //                Console.WriteLine("Invalid Roll Number format.");
        //                continue;
        //            }

        //            Student foundStudent = students.Find(s => s.RollNumber == searchRoll);
        //            if (foundStudent != null)
        //            {
        //                Student.DisplayStudentDetails(foundStudent);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Student with the given Roll Number not found.");
        //            }
        //            break;

        //        case 3:
        //            // Update student grade
        //            Console.Write("Enter Roll Number to update grade: ");
        //            if (!int.TryParse(Console.ReadLine(), out int updateRoll))
        //            {
        //                Console.WriteLine("Invalid Roll Number format.");
        //                continue;
        //            }

        //            Student studentToUpdate = students.Find(s => s.RollNumber == updateRoll);
        //            if (studentToUpdate != null)
        //            {
        //                Console.Write("Enter new grade: ");
        //                string newGrade = Console.ReadLine();
        //                studentToUpdate.UpdateGrade(newGrade);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Student with the given Roll Number not found.");
        //            }
        //            break;

        //        case 4:
        //            // Display total students
        //            Student.DisplayTotalStudents();
        //            break;

        //        case 5:
        //            // Exit the program
        //            Console.WriteLine("Exiting... Thank you for using the University Student Management System.");
        //            return;

        //        default:
        //            Console.WriteLine("Invalid choice. Please try again.");
        //            break;
        //    }
        //}




        // QUESTION NO - 6
        //List<Vehicle> vehicles = new List<Vehicle>();

        //while (true)
        //{
        //    Console.WriteLine("\nVehicle Registration System");
        //    Console.WriteLine("1. Register New Vehicle");
        //    Console.WriteLine("2. Display Vehicle Details");
        //    Console.WriteLine("3. Update Registration Fee");
        //    Console.WriteLine("4. Exit");
        //    Console.Write("Enter your choice: ");

        //    if (!int.TryParse(Console.ReadLine(), out int choice))
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid number.");
        //        continue;
        //    }

        //    switch (choice)
        //    {
        //        case 1:
        //            // Register a new vehicle
        //            Console.Write("Enter Owner Name: ");
        //            string ownerName = Console.ReadLine();

        //            Console.Write("Enter Vehicle Type (Car/Bike/Truck): ");
        //            string vehicleType = Console.ReadLine();

        //            vehicles.Add(new Vehicle(ownerName, vehicleType));
        //            Console.WriteLine("Vehicle registered successfully!");
        //            break;

        //        case 2:
        //            // Display vehicle details
        //            Console.Write("Enter Registration Number to search: ");
        //            if (!int.TryParse(Console.ReadLine(), out int searchReg))
        //            {
        //                Console.WriteLine("Invalid Registration Number format.");
        //                continue;
        //            }

        //            Vehicle foundVehicle = vehicles.Find(v => v.RegistrationNumber == searchReg);
        //            if (foundVehicle != null)
        //            {
        //                Vehicle.DisplayVehicleDetails(foundVehicle);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Vehicle with the given Registration Number not found.");
        //            }
        //            break;

        //        case 3:
        //            // Update registration fee
        //            Console.Write("Enter new Registration Fee: ");
        //            if (!double.TryParse(Console.ReadLine(), out double newFee))
        //            {
        //                Console.WriteLine("Invalid fee amount.");
        //                continue;
        //            }

        //            Vehicle.UpdateRegistrationFee(newFee);
        //            break;

        //        case 4:
        //            // Exit the program
        //            Console.WriteLine("Exiting... Thank you for using the Vehicle Registration System.");
        //            return;

        //        default:
        //            Console.WriteLine("Invalid choice. Please try again.");
        //            break;
        //    }
        //}


        // QUESTION NO -7
        List<Patient> patients = new List<Patient>();
        while (true)
        {
            Console.WriteLine("\n🏥 Hospital Management System");
            Console.WriteLine("1. Admit New Patient");
            Console.WriteLine("2. Display Patient Details");
            Console.WriteLine("3. Get Total Patients");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    // Admit a new patient
                    Console.Write("Enter Patient Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Patient Age: ");
                    if (!int.TryParse(Console.ReadLine(), out int age))
                    {
                        Console.WriteLine("Invalid Age format.");
                        continue;
                    }

                    Console.Write("Enter Ailment: ");
                    string ailment = Console.ReadLine();

                    patients.Add(new Patient(name, age, ailment));
                    Console.WriteLine("Patient admitted successfully!");
                    break;

                case 2:
                    // Display patient details
                    Console.Write("Enter Patient ID to search: ");
                    if (!int.TryParse(Console.ReadLine(), out int searchID))
                    {
                        Console.WriteLine("Invalid Patient ID format.");
                        continue;
                    }

                    Patient foundPatient = patients.Find(p => p.PatientID == searchID);
                    if (foundPatient != null)
                    {
                        Patient.DisplayPatientDetails(foundPatient);
                    }
                    else
                    {
                        Console.WriteLine("Patient with the given ID not found.");
                    }
                    break;

                case 3:
                    // Get total patients admitted
                    Patient.GetTotalPatients();
                    break;

                case 4:
                    // Exit the program
                    Console.WriteLine("Exiting... Thank you for using the Hospital Management System.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

    }
}
