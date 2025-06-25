

using ExemploExplorando.Models;


Person p1 = new Person();
p1.Name = "Tiago";
p1.LastName = "Borges";

Person p2 = new Person();
p2.Name = "Pedro";
p2.LastName = "Neri";


Course englishCourse = new Course();
englishCourse.Name = "English";
englishCourse.Students = new List<Person>();

englishCourse.Students.Add(p1);
englishCourse.Students.Add(p2);
englishCourse.ListStudents();






































// Create a new Person object
// Person p1 = new Person();

// Set properties for the person
// p1.Name = "Tiago";
// p1.LastName = "Borges";
// p1.Age = 30;

// Call the Present method to display the person's information
// p1.Present();