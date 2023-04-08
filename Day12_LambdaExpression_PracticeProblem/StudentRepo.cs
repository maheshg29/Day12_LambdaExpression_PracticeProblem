using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_LambdaExpression_PracticeProblem
{
    public class StudentRepo
    {
        public static List<Student> AddStudent()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Mahesh", PhoneNumber = 9874561232, Address = "Mumbai", Age = 12 });
            students.Add(new Student { Id = 2, Name = "Akshay", PhoneNumber = 9874786413, Address = "Mumbai", Age = 25 });
            students.Add(new Student { Id = 3, Name = "Rajesh", PhoneNumber = 7898456512, Address = "Nashik", Age = 15 });
            students.Add(new Student { Id = 4, Name = "Gaurav", PhoneNumber = 8882224567, Address = "Nagpur", Age = 30 });
            students.Add(new Student { Id = 5, Name = "Pavan", PhoneNumber = 7785412547, Address = "Nashik", Age = 18 });
            students.Add(new Student { Id = 6, Name = "Ram", PhoneNumber = 8882224567, Address = "Nagpur", Age = 30 });
            return students;
        }

        public static void DisplayStudent(List<Student> student)
        {
            foreach (Student studentdisplay in student)
            {
                Console.WriteLine("ID: " + studentdisplay.Id);
                Console.WriteLine("Name: " + studentdisplay.Name);
                Console.WriteLine("Phone Number: " + studentdisplay.PhoneNumber);
                Console.WriteLine("Address: " + studentdisplay.Address);
                Console.WriteLine("Age: " + studentdisplay.Age);
                Console.WriteLine();

            }
        }
    }
}
