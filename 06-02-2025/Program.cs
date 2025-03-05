using System;
using BankandAccountHoldersAssociation;
using CompanyAndDepartmentsComposition;
using EcommercePlatform;
using HospitalSystemAssociation;
using LibraryBookAggregation;
using SchoolandStudentswithCourses_AssociationandAggregation;
using UniversityManagementSystem;

class Program
{
    public static void Main(string[] args)
    {

        // QUESTION NO-1
        //    Book b1 = new Book("Ramayan", "Valmiki");
        //    Book b2 = new Book("Book2", "xyz");
        //    Book b3 = new Book("Book3", "abc");

        //    // Creating libraries
        //    Library l1 = new Library("GLA Central Library");
        //    Library l2 = new Library("GLA AB2 Library");

        //    l1.addBook(b1);
        //    l1.addBook(b2);
        //    l2.addBook(b3);
        //    l2.addBook(b1);
        //    l1.displayBooks();
        //    Console.WriteLine();
        //    l2.displayBooks();


        // QUESTION NO- 2
        //Bank bank1 = new Bank("PNB");
        //Bank bank2 = new Bank("SBI");

        //bank1.openAccount("Shubham", 1000);


        //Customer somesh = new Customer("Shubham", bank2, 1000);
        //Customer krishna = new Customer("Somesh", bank1, 2000);

        //somesh.viewBalance();
        //krishna.viewBalance();


        // QUESTION NO-3
        //Company company = new Company("Capgemini");
        //company.addDepartment("IT");
        //company.addDepartment("HR");

        //Department itDept = new Department("IT");
        //itDept.addEmployee("Somesh");
        //itDept.addEmployee("Shubham");

        //Department hrDept = new Department("HR");
        //hrDept.addEmployee("Rohit");

        //company.showDepartments();
        //hrDept.showEmployees();

        //itDept.showEmployees();



        // QUESTION NO-4

        //School school = new School("Vidyasagar School");

        //Student somesh = new Student("Somesh");
        //Student krishna = new Student("Shubham");

        //Course math = new Course("Mathematics");
        //Course science = new Course("Science");

        //somesh.enrollCourse(math);
        //somesh.enrollCourse(science);
        //krishna.enrollCourse(math);

        //school.addStudent(somesh);
        //school.addStudent(krishna);

        //school.showStudents();

        //math.showStudents();
        //science.showStudents();


        // QUESTION NO-5

        //School school = new School("Vidyasagar School");

        //Student somesh = new Student("Somesh");
        //Student shubham = new Student("shubham");

        //Course math = new Course("Mathematics");
        //Course science = new Course("Science");

        //somesh.enrollCourse(math);
        //somesh.enrollCourse(science);
        //shubham.enrollCourse(math);

        //school.addStudent(somesh);
        //school.addStudent(shubham);

        //school.showStudents();

        //math.showStudents();
        //science.showStudents();


        // QUESTION NO-6
        //Hospital hospital = new Hospital("Nayati Hospital");

        // Create Doctors
        //Doctor doctor1 = new Doctor("OP Sharma");
        //Doctor doctor2 = new Doctor("Pawan Sharma");
        //hospital.addDoctor(doctor2);

        //// Create Patients
        //Patient patient1 = new Patient("Ayush");
        //Patient patient2 = new Patient("Somesh");

        //// Doctors consulting with Patients
        //doctor1.consult(patient1);
        //doctor1.consult(patient2);

        //doctor2.consult(patient1);

        //// Show Doctors and their Consultations
        //hospital.showDoctors();
        //doctor1.showConsultations();
        //doctor2.showConsultations();

        //// Show Patient Consultation History
        //patient1.showConsultationHistory();
        //patient2.showConsultationHistory();


        // QUESTION NO-7
        //Product product1 = new Product("Laptop", 129999.00);
        //Product product2 = new Product("Smartphone", 18999.00);
        //Product product3 = new Product("Headphones", 999.00);

        //// Create a Customer
        //Custom customer = new Custom("Shubham");

        //// Create Orders for the Customer
        //Order order1 = new Order("ORD1", customer);
        //order1.addProduct(product1);
        //order1.addProduct(product2);

        //Order order2 = new Order("ORD2", customer);
        //order2.addProduct(product3);

        //// Customer places orders
        //customer.placeOrder(order1);
        //customer.placeOrder(order2);

        //customer.showOrders();



        // QUESTION NO-7
        Professor professor1 = new Professor("Dr. Asheesh Tiwari");
        Professor professor2 = new Professor("Dr. Rakesh Galav");

        // Create Courses
        Cour course1 = new Cour("Mathematics");
        Cour course2 = new Cour("Computer Science");

        // Assign Professors to Courses
        professor1.assignCourse(course1);
        professor2.assignCourse(course2);

        // Create Students
        Stu student1 = new Stu("Shyam");
        Stu student2 = new Stu("Sundar");

        course1.enrollStudent(student1);
        course2.enrollStudent(student2);
        course1.enrollStudent(student2);

        // Show Course Details and Enrolled Students
        course1.showEnrolledStudents();
        course2.showEnrolledStudents();

        // Show Student's Enrolled Courses
        student1.showCourses();
        student2.showCourses();

    }


}
