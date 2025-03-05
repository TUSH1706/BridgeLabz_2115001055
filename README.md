Capgemini Training
Assignment-22-1-25
Introduction to C# C# is just a simple, secure, robust, portable, platform-independent, architectural neutral, multithreaded, object-oriented programming language with a strong type exception handling mechanism for developing different kinds of applications such as Web, Windows Form, Console, Web Services, Mobile Apps, etc.C# was created by Microsoft in the early 2000s as part of its .NET initiative.

Abstraction from Hardware: C# abstracts away the details of the computer's hardware, making it easier to write and understand code. 2. Platform Independence: C# programs are compiled into Intermediate Language (IL) and run on any device with the .NET runtime (CLR), adhering to the "Write Once, Run Anywhere" principle. 3. Advanced Features: C# provides extensive libraries and frameworks for various tasks, supports object-oriented programming, and handles memory management with automatic garbage collection. 4. Ease of Use: C# has a human-readable syntax, strong error-checking, and powerful development tools that enhance productivity and simplify complex tasks.

Operators:
•	Arithmetic Operator : + , - , * / , %;
•	Relational Operator : == ,!= <, >,<=,>=
•	Logical Operator : && ,||,!
•	Assignment Operator : +=,-=,/=,*=
•	Increment Operator : ++, --,
•	Bitiwse Operator : & , |, ^, ~,x<<1,x>>1
•	Assignment-23-1-25
CLR :The Common Language Runtime (CLR) is a core component of .NET Framework that manages the execution and the lifecycle of all .NET applications (code). It provides various services, including automatic memory management, exception handling, security, and type safety. When a .NET application is compiled, it generates an intermediate language code called Common Intermediate Language (CIL). The CLR is responsible for translating this CIL into machine code and managing the execution of the resulting program. The CLR also provides a platform for interoperability between different programming languages that target the .NET Framework. This means that a program written in one .NET language can easily use libraries written in another .

CIL is a low-level, platform-independent intermediate code used in the .NET framework. When you write and compile C# code, it gets converted into CIL by the C# compiler. This intermediate code is then executed by the Common Language Runtime (CLR).

Key Features:
Platform-Independent: CIL allows .NET applications to run on multiple platforms by being compiled into machine code specific to the platform at runtime using the Just-In-Time (JIT) compiler.
Type-Safe: CIL enforces type safety, ensuring reliable and secure execution. Language Interoperability: Any .NET-supported language (e.g., C#, VB.NET, F#) compiles into CIL, enabling cross-language compatibility. Managed Execution: It benefits from the CLR's features like garbage collection, exception handling, and runtime type checking.
Static:
A static method is a method that belongs to the class itself, rather than to instances (objects) of the class. It is called on the class rather than on an object. Static methods are defined using the static keyword and can be invoked without creating an instance of the class. Belongs to the Class, Not the Instance: Static methods are called on the class itself, not on an instance. Cannot Access Instance Members: Static methods cannot access non-static instance variables or methods (those that belong to an object). They can only access other static members of the class. Can Be Called Directly: You don’t need to create an object to invoke a static method. It’s called directly on the class. No this Keyword: Static methods don’t have access to the this keyword (which refers to the current object in non-static methods).

Assignment-24-1-25
The data type which stores the value directly in the memory is called the Value Data Type in C#. The examples are int, char, boolean, and float which store numbers, alphabets, true/false, and floating-point numbers respectively.

Primitive Value Types:
Numeric Types:

•	int: 32-bit signed integer.
•	long: 64-bit signed integer.
•	short: 16-bit signed integer.
•	byte: 8-bit unsigned integer.
•	float: 32-bit floating-point (7 digits precision).
•	double: 64-bit floating-point (15-16 digits precision).
•	char: Single 16-bit Unicode character.
•	bool: Boolean values (true or false).
Access Modifiers
1.public The code is accessible for all classes 2.private The code is only accessible within the same class 3.protected The code is accessible within the same class, or in a class that is inherited from that class. 4.internal The code is only accessible within its own assembly, but not from another assembly. 5.protected internal: Only code in the same assembly or in a derived class in another assembly can access this type or member. 6.private protected: Only code in the same assembly and in the same class or a derived class can access the type or member.

Type Conversion:
Implicit Conversion
Definition: Automatic type conversion performed by the compiler.
Characteristics:
No data loss occurs during conversion.
Happens between compatible types.
Does not require explicit syntax.
Explicit Conversion (Type Casting) Definition: Conversion that requires explicit syntax because it might result in data loss or a runtime exception.

Syntax: Use the cast operator (type).

Boxing:
the process of converting a Value Type variable (char, int etc.) to a Reference Type variable (object) is called Boxing. Boxing is an implicit conversion process in which object type (super type) is used. Value type variables are generally stored on the stack when they are local variables. When they are fields within a reference type, they are part of the heap-allocated memory for the reference type.

Control Flow
for Loop: The for loop is used when you know the number of iterations in advance. It consists of three parts:
Initialization: Set up the loop counter.
Condition: The loop runs as long as this condition is true.
Increment/Decrement: Update the loop counter after each iteration.
while Loop The while loop runs as long as the condition is true. The condition is checked before each iteration.
do-while Loop The do-while loop is similar to the while loop, but it guarantees that the code is executed at least once because the condition is checked after the loop body.
Assignment - 25-01-2025 
I have learned the following topics through this assignment:
C# Arrays
Create an Array
Access an Array
Accessing using for loop
Modifying an Array
Using length property of array
C# Multi-dimensional Array
C# 2 Dimensional Array (Matrix)
Accessing, finding size, etc., of Multi-Dimensional Array
Using C# Console.Error.WriteLine() Message and Environment.Exit() Method
Assignment - 28-01-2025 
I have learned the following topics through this assignment:
User-Defined Methods
Using Methods Multiple Times
Making Methods More Dynamic
Recursive Methods
Static Methods in C#
.NET Standard Library Methods
System.Math Class in C#
Assignment - 30-01-2025 
I have learned the following topics through this assignment:
The outcome is the usage of Strings
Handling strings and common string functions
Functions and function parameter passing, return the value of function
Use common Built-in Functions and build the logic
Assignment of 31-01-2025 done
Solved more questions on strings and others for logic building purpose through this assignment:
Assignment - 31-1-2025 
I have learned the following topics through this assignment:
Procedural vs Object-oriented Programming Language
Class and Objects
Assignment - 2-2-2025 
I have learned the following topics through this assignment:
C# Constructors
Instance vs. Class Variables
Access Modifiers Concepts
Assignment - 4-2-2025
I have learned the following topics through this assignment:
Usage of THIS keyword
Static data members
sealed keyword
IS OPERATOR
Assignment - 6-2-2025 
I have learned the following topics through this assignment:
Object Oriented Design Principles
Class Diagram
Object Diagrams
Sequence Diagrams
HasARelationship vs IsARelationship
Association, Aggregation, Composition
Assignment - 08-02-2025 
I have learned the following topics through this assignment:
Inheritance
Single Level Inheritance
Multilevel Inheritance
Hierarchical Inheritance
Key Features of Inheritance
Method Overriding
Constructor Inheritance in C#
Polymorphism and Inheritance
Access Modifiers and Inheritance
Assignment - 10-02-2025 
I have learned the following topics through this assignment:
Encapsulation
Polymorphism
Interface
Abstract Classes
Assignment - 12-2-25 
Single Linked List
Double Linked List
Circular Linked List
Assignment - 13-2-25
Stack
Queue
HashMap(known as Dictionary)
Hash Function
Assignment - 14-2-25 
Bubble Sort
Insertion Sort
Merge Sort
Quick Sort
Assignment - 16-2-25
StringBuilder
StringBuffer
FileReader
InputStreamReader
Linear Search
Binary Search
Assignment - 17-2-25
General Algorithm Best Practices
Time and space Complexity Optimization
18-2-25
Introduction to Generics in C#

Generics in C# allow developers to create type-safe, reusable, and flexible code by introducing parameterized types. Instead of using object types, generics enable compile- time type checking and eliminate the need for explicit type casting. Why Use Generics?
Type Safety: Ensures that only valid data types are used, preventing InvalidCastException at runtime.
Code Reusability: A single generic class/method can work with multiple data types.
Eliminates Type Casting: Avoids unnecessary explicit casting, improving code readability.
Compile-time Checking: Errors are caught early during compilation rather than at runtime.
Assigment 18-2-25:
Basic Practices for Generics class

Assignment 20-2-25:
C# I/O Streams Types of Streams

File Streams
Object Streams
ByteArray Streams
Buffered Streams
Reader and Writer Key Considerations
Assignment 21-2-25:
Exceptions
Types of Exceptions
Checked Exceptions
Unchecked Exceptions
Custom Exceptions
Handling Exceptions
try-catch blocks
try-catch-finally blocks
try-with-resources statement
throws clause
throw statement
Creating Custom Exceptions
Extending Exception Class
Defining Constructors
Assignment-22-2-25:
Regex
MetaCharacter
Quantifier
Common Patterns:
Email Validation
Password Strength
Phone Number Format
C# Regex API
Pattern
Matcher
Methods:
find()
matches()
replaceAll()
Introduction to NUnit Framework
NUnit Annotations
Writing Test Cases
Structure of a Test Class
Assertions
