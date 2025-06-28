using System.Globalization;
using ExemploExplorando.Models;


// To set Data and Time: 

DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("MM/dd/yyyy  HH:mm"));












//------------------------------------------------------------

// // Set Money / Values: 


// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal MonetaryValue = 1582.40M;

// // Print: 
// Console.WriteLine(MonetaryValue.ToString("N2"));

// // To Include %: 
// double percentage = .3421;

// Console.WriteLine(percentage.ToString("P"));

// // Decimals house:
// int number = 123456;
// Console.WriteLine(number.ToString("##-##-##"));


// // Option 1 most usualy :Console.WriteLine($"{MonetaryValue:C}");

// // option 2:  change location of culture:  Console.WriteLine(MonetaryValue.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));



// ---------------------------



// To include Numbers: 
// int number1 = 10;
// int number2 = 20;



// int result = number1 + number2;

// Console.WriteLine(result);





//-----------------------------------------


// To Include Person: 

// Person p1 = new Person(name: "Tiago", lastname: "Borges");
// Person p2 = new Person(name: "Pedro", lastname: "Neri");



// Course englishCourse = new Course();
// englishCourse.Name = "English";
// englishCourse.Students = new List<Person>();

// englishCourse.Students.Add(p1);
// englishCourse.Students.Add(p2);
// englishCourse.ListStudents();


//-----------------------------------

// To create new Person/Object: 

// Create a new Person object
// Person p1 = new Person();

// Set properties for the person
// p1.Name = "Tiago";
// p1.LastName = "Borges";
// p1.Age = 30;

// Call the Present method to display the person's information
// p1.Present();