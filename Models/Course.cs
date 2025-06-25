using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models


{
    public class Course
    {
        public string Name { get; set; }
        public List<Person> Students { get; set; }
        public void AddStudent(Person Student)

        {
            Students.Add(Student);

        }


        public int GetStudentCount()

        {
            return Students.Count;
        }

        public bool RemoveStudent(Person student)
        {
            return Students.Remove(student);
        }
    }


}