using System.Globalization;
using ExemploExplorando.Models;


Dictionary<string, string> uf = new Dictionary<string, string>();
// to add

uf.Add("SP", "São Paulo");
uf.Add("RJ", "Rio de Janeiro");
uf.Add("MG", "Minas Gerais");

// To enter the Uf 
//Console.WriteLine(uf["MG"]);




foreach (var item in uf)

{
    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
}


Console.WriteLine("----------------");

uf.Remove("MG");
uf["SP"] = "São Paulo - Changed Value";

foreach (var item in uf)
{
    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

}

string key = "SC";
Console.WriteLine($"Verifying  element: {key}");

if (uf.ContainsKey(key))
{
    Console.WriteLine($"There is the value: {key}");
}
else
{
    Console.WriteLine($"There isn't the value, it is ok to add the key: {key}");
}





// //Inverse the Queue: Pile

// Stack<int> pile = new Stack<int>();

// pile.Push(4);
// pile.Push(6);
// pile.Push(8);
// pile.Push(10);


// foreach (int item in pile)

// {
//     Console.WriteLine(item);
// }

// //remove the last element and return it:
// Console.WriteLine($"Remove the element at top: {pile.Pop()} ");

// pile.Push(20);
// foreach (int item in pile)

// {

//     Console.WriteLine(item);
// }



//--------------------------------------------

// Queue 

// Queue<int> line = new Queue<int>();

// line.Enqueue(2);
// line.Enqueue(4);
// line.Enqueue(6);
// line.Enqueue(8);

// foreach (int item in line)
// {

//     Console.WriteLine(item);

// }

// Console.WriteLine($"Remove the element: {line.Dequeue()}");


// foreach (int item in line)
// {

//     Console.WriteLine(item);
// }


//-----------------------


// new ExemploException().Method1();

// ------------------


// string[] lines = File.ReadAllLines("Files/fileRead.txt");

// foreach (string line in lines)

// {

//     Console.WriteLine(line);

// }






//----------------------------------------- 


// // To set Data and Time: 

// DateTime data = DateTime.Now;

// Console.WriteLine(data.ToString("MM/dd/yyyy  HH:mm"));












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