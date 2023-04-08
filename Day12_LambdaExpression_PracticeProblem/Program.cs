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
            Console.WriteLine("Select any one option \n 1. add data to add Student\n" +
                " 2. Retrieve all record from the list for age between 12 to 18 using linq.");
            int option = Convert.ToInt32(Console.ReadLine());
            
            switch (option)
            {
                case 1:
                    List<Student> students =StudentRepo.AddStudent();
                    StudentRepo.DisplayStudent(students);
                    break;

                case 2:
                    List<Student> students1 = StudentRepo.AddStudent();
                    List<Student> selectedStudent = students1.Where(s => s.Age >= 12 && s.Age <= 18).ToList();
                    StudentRepo.DisplayStudent(selectedStudent);
                    break;

                default:
                    Console.WriteLine("Please select correct number");
                    break;
            }
        }
    }
}
