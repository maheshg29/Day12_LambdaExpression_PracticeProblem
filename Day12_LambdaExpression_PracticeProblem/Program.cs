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
                " 2. Retrieve all record from the list for age between 12 to 18 using linq.\n" +
                " 3. Sort students data in descending order based on TotalMarks.\n" +
                " 4. Display all the student records in each address.");
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

                case 3:
                    List<Student> students2 = StudentRepo.AddStudent();
                    List<Student> OrderbyStudent = students2.OrderByDescending(s => s.Mark).ToList(); ;
                    StudentRepo.DisplayStudent(OrderbyStudent);
                    break;

                case 4:
                    List<Student> students3 = StudentRepo.AddStudent();
                    var GroupByAddress = students3.GroupBy(s => s.Address).ToList();
                    foreach (var group in GroupByAddress)
                    {
                        Console.WriteLine("Students with Age: " + group.Key);
                        Console.WriteLine("-----------------------");
                        StudentRepo.DisplayStudent(group.ToList());
                    }
                    break;


                default:
                    Console.WriteLine("Please select correct number");
                    break;
            }
        }
    }
}
