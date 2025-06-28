using System.Globalization;
using ExemploExplorando.Models;


CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal MonetaryValue = 1582.40M;

Console.WriteLine($"{MonetaryValue:C}");

// optional, change location of culture:  Console.WriteLine(MonetaryValue.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));











// ---------------------------

// int number1 = 10;
// int number2 = 20;



// int result = number1 + number2;

// Console.WriteLine(result);

//-----------------------------------------

// Person p1 = new Person(name: "Tiago", lastname: "Borges");
// Person p2 = new Person(name: "Pedro", lastname: "Neri");



// Course englishCourse = new Course();
// englishCourse.Name = "English";
// englishCourse.Students = new List<Person>();

// englishCourse.Students.Add(p1);
// englishCourse.Students.Add(p2);
// englishCourse.ListStudents();


//-----------------------------------


// Create a new Person object
// Person p1 = new Person();

// Set properties for the person
// p1.Name = "Tiago";
// p1.LastName = "Borges";
// p1.Age = 30;

// Call the Present method to display the person's information
// p1.Present();