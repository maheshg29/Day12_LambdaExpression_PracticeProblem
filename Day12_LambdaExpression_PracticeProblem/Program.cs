using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_LambdaExpression_PracticeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 12 Practice Problem on Lambda Expression");
            Console.WriteLine("Select any one option \n 1. add data to add Student");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    List<Student> students = new List<Student>();
                   
                    students.Add(new Student { Id=1,Name="Mahesh",PhoneNumber=9874561232,Address="Mumbai",Age=30});
                    students.Add(new Student { Id = 2, Name = "Akshay", PhoneNumber = 9874786413, Address = "Mumbai", Age = 25 });
                    students.Add(new Student { Id = 3, Name = "Rajesh", PhoneNumber = 7898456512, Address = "Nashik", Age = 45 });
                    students.Add(new Student { Id = 4, Name = "Gaurav", PhoneNumber = 8882224567, Address = "Nagpur", Age = 30 });

                    foreach (Student student in students)
                    {
                        Console.WriteLine("ID: " + student.Id);
                        Console.WriteLine("Name: " + student.Name);
                        Console.WriteLine("Phone Number: " + student.PhoneNumber);
                        Console.WriteLine("Address: " + student.Address);
                        Console.WriteLine("Age: " + student.Age);
                        Console.WriteLine();
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
