using System;
using AnimalHierarchy;
using BankAccountTypes;
using BookAndAuthor;
using EducationCourseHierarchy;
using EmployeeMAnagementSystem;
using OnlineRetailOrderManagement;
using RestaurantManagementSystem;
using SchoolSystem;
using SmartHomeDevices;
using VehicleandTransportSystem;
using VehicleManage;

class Program
{
    public static void Main(string[] args)
    {

        // QUESTION NO-1
        //Animal animal = new Animal("Amnimal", 2);
        //animal.MakeSound();
        //Animal dog = new Dog("Shera", 2);
        //dog.MakeSound();
        //Animal cat = new Cat("Cash", 1);
        //cat.MakeSound();
        //Animal bird = new Bird("uddd", 3);
        //bird.MakeSound();



        // QUESTION NO-2
        //Employee employee = new Employee("Employee", 1, 1000);
        //Employee manager = new Manager("HR Didi", 101, 600000, 6);
        //Employee developer = new Developer("Prahil", 102, 2000000, ".NET");
        //Employee intern = new Intern("Somesh", 111, 50000, "6 months");

        //employee.DisplayDetails();
        //manager.DisplayDetails();
        //developer.DisplayDetails();
        //intern.DisplayDetails();



        // QUESTION NO-3

        //Vehicle[] vehicles = new Vehicle[]
        //{
        //    new Car(200, "Petrol", 5),
        //    new Truck(120, "Diesel", 5000),
        //    new Motorcycle(180, "Petrol", true)
        //};

        //foreach (var vehicle in vehicles)
        //{
        //    vehicle.DisplayInfo();
        //    Console.WriteLine();
        //}


        // QUESTION NO-4
        //Book author = new Author("Godaan", 1936, "Munshi Premchand", "Themed around the socio-economic deprivation as well as the exploitation of the village poor, the novel was the last complete novel of Premchand.");
        //author.DisplayInfo();



        // QUESTION NO-5
        //Device thermostat = new Thermostat("T12", "Online", 16);
        //thermostat.DisplayStatus();



        // QUESTION NO-6
        //Order order = new Order("O101", DateTime.Now);
        //ShippedOrder shippedOrder = new ShippedOrder("O101", DateTime.Now, 1234567);
        //DeliveredOrder deliveredOrder = new DeliveredOrder("O101", DateTime.Now, 1234567, DateTime.Now.AddDays(3));

        //Console.WriteLine($"Order ID: {order.orderId}, Status: {order.GetOrderStatus()}");
        //Console.WriteLine($"Order ID: {shippedOrder.orderId}, Tracking: {shippedOrder.trackingNumber}, Status: {shippedOrder.GetOrderStatus()}");
        //Console.WriteLine($"Order ID: {deliveredOrder.orderId}, Tracking: {deliveredOrder.trackingNumber}, Delivery Date: {deliveredOrder.deliveryDate}, Status: {deliveredOrder.GetOrderStatus()}");


        // QUESTION NO-7
        //Course basicCourse = new Course("Introduction to Programming", 40);
        //OnlineCourse onlineCourse = new OnlineCourse("Web Development", 50, "Coursera", true);
        //PaidOnlineCourse paidCourse = new PaidOnlineCourse("Advanced C#", 60, "Bridgelabz", false, 19999.00, 20);

        //basicCourse.DisplayInfo();
        //Console.WriteLine();
        //onlineCourse.DisplayInfo();
        //Console.WriteLine();
        //paidCourse.DisplayInfo();



        // QUESTION NO-8

        //BankAccount savings = new SavingsAccount("S12345", 5000.0, 3.5);
        //BankAccount checking = new CheckingAccount("C765443", 2000.0, 1000.0);
        //BankAccount fixedDeposit = new FixedDepositAccount("c76543", 10000.0, 12);

        //savings.DisplayAccountType();
        //checking.DisplayAccountType();
        //fixedDeposit.DisplayAccountType();



        // QUESTION NO-9
        //Person teacher = new Teacher("Mohit Chaudhary", 35, "Mathematics");
        //Person student = new Student("Somesh", 21, "Graduation");
        //Person staff = new Staff("Ramesh", 40, "Administrator");

        //teacher.DisplayRole();
        //student.DisplayRole();
        //staff.DisplayRole();




        // QUESTION NO-10
        //Worker chef = new Chef("sp", 101, "Italian Cuisine");
        //Worker waiter = new Waiter("kp", 201, 5);

        //chef.PerformDuties();
        //waiter.PerformDuties();


        // QUESTION NO-11
        ElectricVehicle tesla = new ElectricVehicle(200, "Mahindra BE6e", 100);
        PetrolVehicle ford = new PetrolVehicle(180, "Tata Curvv", 60);

        tesla.DisplayInfo();
        tesla.Charge();

        ford.DisplayInfo();
        ford.Refuel();

    }
}
