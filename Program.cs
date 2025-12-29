// See https://aka.ms/new-console-template for more information



// What is C#?
// C# is pronounced "C-Sharp".
// It is an object-oriented programming language created by Microsoft that runs on the .NET Framework.
// C# has roots from the C family, and the language is close to other popular languages like C++ and Java.
// The first version was released in year 2002. The latest version, C# 13, was released in November 2024.
// C# is used for:
// Mobile applications, Desktop applications, Web applications, Web services, Web sites,Games, VR, Database applications
// And much, much more!
// Why Use C#?
// It is one of the most popular programming languages in the world
// It is easy to learn and simple to use
// It has huge community support
// C# is an object-oriented language which gives a clear structure to programs and allows code to be reused, lowering development costs
// As C# is close to C, C++ and Java, it makes it easy for programmers to switch to C# or vice versa



// For Creating Project
// cmd -> dotnet new console -o project_name

// console function syntax

// Console.WriteLine("Hello, World!");  // For Printing Data
// Console.Write("My self shahnawaz"); // This Console.write is used to multiple data in one line
// Console.WriteLine(); //is used in C# to display output on the console (screen) and then move the cursor to the next line.

// varaibles and DataTypes;
// Type: int, string, bool, char, double, long, array, object, class, interface

// int number = 6769; // int: store whole number
// Console.WriteLine(number);

// long largeNumber = 456451234245656456; // long: store large whole number
// Console.WriteLine(largeNumber);

// string name = "shahnawaz"; // string: store text
// Console.WriteLine(name);

// double decimalNumber = 88.09; // double: store decimal number
// Console.WriteLine(decimalNumber);

// bool isStudent = true; // bool: check statement
// Console.WriteLine(isStudent);

// char A = 'A'; // char: store only one character
// Console.WriteLine(A);



// array method

// int[] num= {1,2,3,4,5};
// Console.WriteLine(num[2]); // One data print for an array

// int[] num= {1,2,3,4,5};
// for(int i = 0; i<=num.Length; i++) { // For multiple Data Create loop
//     Console.WriteLine(num[i]);
//     // Console.Write(num[i] + "\t");
// }

// int[] num = {1,2,3,4,5};
// for(int i=0; i < num.Length; i++) {
//     for(int j=0; j<=i; j++) {
//         Console.WriteLine(num[i]+ "\t");
//     }
//     Console.WriteLine();
// }


// int[] num = {1, 2, 3, 4, 5};

// for (int i = 0; i < num.Length; i++)
// {
//     for (int j = 0; j <= i; j++)
//     {
//         Console.Write(num[i] + "\t"); // prints on same line
//     }
//     Console.WriteLine(); // moves to new line after each row
// }

// int a = 4, b = 5;
// int a = Math.Min(5, 10);
// Console.WriteLine(a);

// int a = Math.Max(5, 10);
// Console.WriteLine(a);


// Calculator
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// string op = Console.ReadLine();

// if (op == "+")
// {
//     Console.WriteLine(num1 + num2);
// }
// else if (op == "-")
// {
//     Console.WriteLine(num1 - num2);
// }
// else if (op == "*")
// {
//     Console.WriteLine(num1 * num2);
// }
// else if (op == "/")
// {
//     if (num2 != 0)
//         Console.WriteLine(num1 / num2);
//     else
//         Console.WriteLine("Cannot divide by zero");
// }
// else
// {
//     Console.WriteLine("Invalid operator");
// }

// function, if_else, switch case, loops, break, continue, -> similar as javaScript

// Object Oriented Programs
// 1. Inheritance
// Single Inheritance, Multilevel Inheritance, Multiple Inheritance, Hierarchical Inheritance, Hybrid Inheritance.
// 2. Encapsulation
// public, private, protected.
// 3. Polimorpism
// method overloading, method overriding
// 4. Abstraction


// class and method
// class Animal
// {
//     public string name = "cat";
//     public void naming()
//     {
//         Console.WriteLine("hello");
//     }
// }

// class Programs
// {
//     static void Main(string[] args)
//     {
//         Animal an1 = new Animal();
//       an1.naming();
//     }
// }


// class method constructor

// class Student
// {
//     public string name;
//     public int age;
//     public Student(string st_name, int st_age)
//     {
//         name = st_name;
//         age = st_age;
//     }
// }

// class Programs
// {
//     static void Main(string[] args)
//     {
//         Student st1 = new Student("mariyaaaa", 420);
//         Console.WriteLine(st1.name);
//     }
// }


// Practice Questions (OOP Basics)

// Q1. Class & Object
// Create a class Student with:
// variables: name, rollNo
// method: displayDetails()
// Create an object and print the student details.

// class Student {
//     public string name = "shahnawaz";
//     public int rollNo = 19;

//     public void displayDetails() {
//         Console.WriteLine("Name: " + name);
//         Console.WriteLine("Roll No: " + rollNo);
//     }

// }

// class Programs{
//     static void Main(string[] args) {
//         Student st1 = new Student();
//         st1.name = "shahnawaz";
//         st1.rollNo = 19;
//         st1.displayDetails();
//     }
// }

// Q2. Default Constructor
// Create a class Car that:
// has variables brand, speed
// uses a default constructor to initialize values
// displays the values using a method

// class Car{
//     public string brand;
//     public int speed;

//     public Car(string cr_brand, int cr_speed) {
//         brand = cr_brand;
//         speed = cr_speed;
//     }
// }

// class Program {
//     static void Main(string[] args) {
//         Car cr_info = new Car("BMW M5", 560);
//         Console.WriteLine(cr_info.brand + " " + cr_info.speed);
//     }
// }

// Q3. Parameterized Constructor
// Create a class Book with:
// variables: title, author, price
// a parameterized constructor
// a method to display book details

// class Book {
//     public string title;
//     public string author;
//     public int price;
    
//     public Book(string b_title, string b_author, int b_price) {
//         title = b_title;
//         author = b_author;
//         price = b_price;
//     }

//     public void display() {
//         Console.Write(title + author + price);
//     }
// }

// class Program{
//     static void Main(string[] args) {
//         Book sellBook = new Book("Maths", "Algebra", 210);
//         sellBook.display();
//     }
// }

// Q4. Constructor Overloading
// Create a class Rectangle that:
// has variables length, width
// one constructor with no parameters
// one constructor with two parameters
// method to calculate and display area

// class Rectangle{
//     public int length;
//     public int width;

//     public Rectangle(){

//     }

//     public Rectangle(int r_length, int r_width) {
//         length = r_length;
//         width = r_width;
//     }

//     public int Area() {
//         return length * width;
//     }
// }

// class Program{
//     static void Main(string[] args) {
//         Rectangle shape = new Rectangle(3,4);
//         Console.WriteLine(shape.Area());
//     }
// }

// Q5. Object Creation Using Constructor
// Create a class Employee with:
// variables: id, name, salary
// constructor to initialize all variables
// create two objects with different values and display them

// class Employee{
//     public int id;
//     public string name;
//     public int salary;

//     public Employee(int e_id, string e_name, int e_salary) {
//         id = e_id;
//         name = e_name;
//         salary = e_salary;
//     }
//     public void Display() {
//         Console.WriteLine( id + " " + name + " " + salary);
    
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Employee emp1 = new Employee(101, "Alice", 50000);
//         Employee emp2 = new Employee(102, "Bob", 60000);

//         emp1.Display();
//         emp2.Display();
//     }
// }


// Object Oriented Programs
// 1. Inheritance
// Single Inheritance, Multilevel Inheritance, Multiple Inheritance, Hierarchical Inheritance, Hybrid Inheritance.
// 2. Encapsulation
// public, private, protected.
// 3. Polimorpism
// method overloading, method overriding
// 4. Abstraction

// Inheritance Topics:
// Inheritance is an OOP concept where one class (called the child/derived class) acquires the properties and methods of another class (called the parent/base class).

// class Animal
// {
//     public void Eat()
//     {
//         Console.WriteLine("Animal is eating");
//     }
// }

// class Dog : Animal
// {
//     public void Bark()
//     {
//         Console.WriteLine("Dog is barking");
//     }
// }

// class Program{
//     static void Main(string[] args) {
//         Dog pet = new Dog();
//         pet.Eat();
//     }
// }


// TYpes of Inheritance:

// 1. Single Inheritance: (one parent one child)
// One child class inherits from one parent class. 

// class A {
//     public void show() {
//         Console.WriteLine("Class A");
//     }
// }

// class B : A {

// }

// class Program{
//     static void Main(string[] args) {
//         B shows = new B();
//         shows.show();
//     }
// }

// 2. Multilevel Inheritance: (loop of parent and child i.e. grandfather -> father -> son)
// A class is derived from another derived class.

// class A
// {
//     public void ShowA(string name) {
//         Console.WriteLine(name);
//     }
// }

// class B : A
// {
//     public void ShowB() { }
// }

// class C : B
// {
//     public void ShowC() { }
// }

// class Program{
//     static void Main(string[] args) {
//         C alpha = new C();
//         alpha.ShowA("hello");
//     }
// }

// 3. Hierarchical Inheritance (one parent many child)
// Multiple child classes inherit from the same parent class.

// class A
// {
//     public void ShowA(string name) {
//         Console.WriteLine(name);
//     }
// }

// class B : A
// {
//     public void ShowB() { }
// }

// class C : A
// {
//     public void ShowC() { }
// }

// class Program{
//     static void Main(string[] args) {
//         C alpha = new C();
//         alpha.ShowA("hello");
//     }
// }

// Polimorpism Topics
// Polymorphism means “many forms.”
// In OOPS, it allows the same method name to behave differently based on the object or situation.

// 1. Method Overriding: (example: same person but differ behaviour)
// Child class provides its own implementation of a virtual method.
// -> different class but same method

// class Animal {
//     public virtual void sounds() {
//         Console.WriteLine("animal like sound");
//     }
// }

// class Dog : Animal {
//     public override void sounds() {
//         Console.WriteLine("bhoo bhoo");
//     }
// }

// class Program{
//     static void Main(string[] args) {
//         Animal so_und = new Dog();
//         so_und.sounds();
//     }
// }

// 2. Method overloading: (example: same method but diffe parameters)
// ---> same class but different method with parameter

// class Calculator
// {
//     public int Add(int a, int b)
//     {
//         return a + b;
//     }

//     public int Add(int a, int b, int c)
//     {
//         return a + b + c;
//     }

//     public double Add(double a, double b)
//     {
//         return a + b;
//     }
// }

// class Program {
//     static void Main(string[] args) 
//     {
//         Calculator calc = new Calculator();

//         int receive_1 = calc.Add(2, 3);
//         Console.WriteLine(receive_1);
//         int receive_2 = calc.Add(2, 3, 4);
//         Console.WriteLine(receive_2);
//         double receive_3 = calc.Add(2.5, 3.5);
//         Console.WriteLine(receive_3);

//     }
// }

// encapsulation
// Encapsulation is one of the four main pillars of Object-Oriented Programming (OOP).
// It means wrapping data (fields) and methods (functions) together into a single unit (class) and restricting direct access to some of the object’s data.

// class Person
// {
//     // 1. Private member
//     private int age;

//     // 2. Public method (to access private data)
//     public void SetAge(int a)
//     {
//         age = a;
//     }

//     // 3. Protected member
//     protected string name;
// }

// class Student : Person
// {
//     public void SetName(string n)
//     {
//         name = n; // protected member accessed in child class
//     }

//     public void Show()
//     {
//         Console.WriteLine("Name: " + name);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Student s = new Student();

//         // Public access
//         s.SetAge(18);     // allowed (public method)
//         s.SetName("Alex");

//         s.Show();

//         // s.age; ❌ Not allowed (private)
//         // s.name; ❌ Not allowed (protected)
//     }
// }


// Abstraction Oops
// Abstraction means hiding the internal implementation and showing only what is necessary to the user.

// Real-life example:
// You use an ATM to withdraw money.
// You don’t know how the machine processes it internally—you only see the options.

// What is an Interface?
// An interface Contains only abstract methods (methods without a body)
// Specifies what a class must do
// Is used to achieve 100% abstraction

// Abstract class (Abstraction)
// abstract class Animal
// {
//     public abstract void Sound();  // Abstract method (No body)
//     public abstract void Sleep();
// }

// // Concrete class that inherits from the abstract class
// class Dog : Animal
// {
//     public override void Sound()
//     {
//         Console.WriteLine("Dog barks");
//     }

//     public override void Sleep()
//     {
//         Console.WriteLine("Dog sleeps at night");
//     }
// }

// class Cat : Animal
// {
//     public override void Sound()
//     {
//         Console.WriteLine("Cat meows");
//     }

//     public override void Sleep()
//     {
//         Console.WriteLine("Cat sleeps during the day");
//     }
// }

// // Main class
// class Program
// {
//     static void Main()
//     {
//         // Abstraction using an abstract class reference
//         Animal animal1 = new Dog();
//         animal1.Sound();
//         animal1.Sleep();

//         Animal animal2 = new Cat();
//         animal2.Sound();
//         animal2.Sleep();
//     }
// }


// Explanation of Abstraction:
// Animal is an abstract class, which defines the structure (abstract methods) but leaves the details to the derived classes (Dog and Cat).
// Dog and Cat provide concrete implementations for Sound() and Sleep(), hiding the implementation details.
// Main: We use the abstract class reference to interact with Dog and Cat objects, showcasing abstraction.



// Interface (Abstraction)
// interface Animal
// {
//     void Sound();  // abstract method
//     void Sleep();
// }

// class Dog : Animal
// {
//     public void Sound()
//     {
//         Console.WriteLine("Dog barks");
//     }

//     public void Sleep()
//     {
//         Console.WriteLine("Dog sleeps at night");
//     }
// }

// // Another class implementing the interface
// class Cat : Animal
// {
//     public void Sound()
//     {
//         Console.WriteLine("Cat meows");
//     }

//     public void Sleep()
//     {
//         Console.WriteLine("Cat sleeps during the day");
//     }
// }

// // Main class
// class Program
// {
//     static void Main()
//     {
//         // Abstraction using interface reference
//         Animal animal1 = new Dog();
//         animal1.Sound();
//         animal1.Sleep();

//         Animal animal2 = new Cat();
//         animal2.Sound();
//         animal2.Sleep();
//     }
// }


// Explanation of Interface:
// IAnimal is an interface, which defines methods like Sound() and Sleep() but doesn't provide any implementation.
// Dog and Cat classes implement the interface and define how those methods should behave.
// Main: We interact with the interface type (IAnimal) for abstraction, while the concrete implementations are provided by Dog and Cat.

// Key Differences between Abstraction and Interface in C#:
// Abstraction (using an abstract class) provides a partial implementation and defines abstract methods that must be implemented by subclasses.
// Interface defines a contract (methods) with no implementation. Any class that implements the interface must provide its own implementation for the methods.
// Abstract classes can have both abstract (without implementation) and concrete methods, while interfaces only contain method declarations.

// Abstraction example question
// abstract class Vehicle{
//     public abstract void StartEngine();
//     public void StopEngine() {
//         Console.WriteLine("Engine stopped");
//     }
// }

// class Car : Vehicle{
//     public override void StartEngine() {
//         Console.WriteLine("Car engine started");
//     }
// }

// class Program{
//     static void Main(string[] args) {
//         Car v_car = new Car();
//         v_car.StopEngine();
//     }
// }

// question for interface

// Problem 1

// interface IPrintable{
//     void Print();
// }

// class Document : IPrintable{
//     public void Print() {
//         Console.WriteLine("Printing Document");
//     }
// }

// class Program{
//     static void Main(string[] args) {
//         Document d = new Document();
//         d.Print();
//     }
// }

// Problem 2

// interface IReadable{
//     void Read();
// }
// interface IWritable{
//     void Write();
// }

// class FileHandler : IReadable, IWritable{
//     public void Read(){
//         Console.WriteLine("Reading file");
//     }
//     public void Write(){
//         Console.WriteLine("Writing file");
//     }
// }

// class Program{
//     static void Main(string[] args) {
//         FileHandler file = new FileHandler();
//         file.Read();
//         file.Write();
//     }
// }


// Problem 3

// interface IEmployee{
//     int salary();
//     void DisplaySalary();
// }

// class Manager : IEmployee{
//     public void salary() {

//     }
//     public void DisplaySalary() {
//         Console.WriteLine(salary());
//     }
// }

// class Program{
//     static void Main(string[] args) {
//         Manager m_s = new Manager();
//         m_s.salary(20,30);
//         m_s.DisplaySalary();
//     }
// }

try {
    int[] muNumbers = {1,2,3};
    Console.WriteLine(muNumbers[10]);
}
catch(Exception e) {
    Console.WriteLine(e.Message);
}