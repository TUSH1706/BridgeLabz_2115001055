using Assignment_2_2_2025;

class Program
{
    public static void Main(string[] args)
    {
        //Console.Write("Enter Product Name: ");
        //Console.Write("Enter Product Price: ");
        //Product p1 = new Product("Oppo" ,20000);
        //p1.DisplayProductDetails();

        //Product product2 = new Product("Laptop", 999.99);
        //product2.DisplayProductDetails();

        //Product.DisplayTotalProducts();


        // Question No-2
        //Course course1 = new Course("Full stack",3, 10000);
        //course1.DisplayCourseDetails();

        //// Updating Institute Name
        //Console.Write("Enter new Institute Name: ");
        //string newInstitute = Console.ReadLine();
        //Course.UpdateInstituteName(newInstitute);


        // Question No-3

        //Vehicle vehicle1 = new Vehicle("Shubham Das", "G-Wagon");
        //vehicle1.DisplayVehicleDetails();

        //// Updating registration fee
        //Console.Write("Enter new Registration Fee: ");
        //double newFee = double.Parse(Console.ReadLine());
        //Vehicle.UpdateRegistrationFee(newFee);


        // Access Modifiers

        //Question No - 1

        //Student student1 = new Student(101, "Alice", 8.5);
        //student1.DisplayDetails();

        //// Creating a postgraduate student
        //PostgraduateStudent pgStudent = new PostgraduateStudent(201, "Bob", 9.2, "Artificial Intelligence");
        //pgStudent.DisplayDetails();

        //// Updating CGPA
        //Console.Write("Enter new CGPA for Alice: ");
        //double newCgpa = double.Parse(Console.ReadLine());
        //student1.SetCGPA(newCgpa);
        //student1.DisplayDetails();



        // Question No -2
        //Book book1 = new Book("978-0131101630", "The C Programming Language", "Brian Kernighan");
        //book1.DisplayDetails();

        //EBook ebook1 = new EBook("978-1492052203", "C# in Depth", "Jon Skeet", 5.2);
        //ebook1.DisplayDetails();

        // QUestion No-3

        //BankAccount account1 = new BankAccount("123456", "Alice Johnson", 1500);
        //account1.DisplayDetails();
        //account1.Deposit(500);
        //account1.Withdraw(200);
        //Console.WriteLine($"Current Balance: {account1.GetBalance()}");

        //Console.WriteLine("\n--- Savings Account Example ---");
        //SavingsAccount savings1 = new SavingsAccount("789012", "John Doe", 2000, 5);
        //savings1.DisplayDetails();


        // QUestion No - 4

        Employee emp1 = new Employee(101, "Engineering", 50000);
        emp1.DisplayDetails();
        emp1.SetSalary(55000);
        Console.WriteLine($"Updated Salary: {emp1.GetSalary()}");

        Console.WriteLine("\n--- Manager Example ---");
        Manager mgr1 = new Manager(201, "HR", 80000, "HR Manager");
        mgr1.DisplayDetails();
        mgr1.SetSalary(85000);
        mgr1.SetRole("Senior HR Manager");
        Console.WriteLine($"Updated Role: {mgr1.GetRole()}, Updated Salary: {mgr1.GetSalary()}");

    }
}
