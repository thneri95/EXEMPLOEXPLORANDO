using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemploExplorando.Models
{
    public class Course
    {
        public string Name { get; set; }

        public List<Person> Students { get; set; }

        // Constructor to initialize the Students list. This is crucial to avoid NullReferenceException.
        public Course()
        {
            Students = new List<Person>();
        }

        public void AddStudent(Person student)
        {
            Students.Add(student);
        }

        public int GetStudentCount()
        {

            return Students.Count;
        }

        public bool RemoveStudent(Person student)
        {
            return Students.Remove(student);
        }

        public void ListStudents()
        {

            Console.WriteLine($"Students in '{Name}' course:");

            for (int count = 0; count < Students.Count; count++)
            {
                string text = "Nº " + count + " - " + Students[count].FullName;
                Console.WriteLine(text); // Assuming Person has a FullName property

            }



        }
    }
}