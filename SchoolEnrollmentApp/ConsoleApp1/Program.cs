
//This is a simple SchoolEnrollment app  
// to help school administrators manage student enrollments. 

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SchoolEnrollmentApp.Data;
using SchoolEnrollmentApp.Models;
using SchoolEnrollmentApp.Repositories;

namespace SchoolEnrollmentApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Add a new student
            // Console.WriteLine("Enter student's ID:");
            // var studentId = int.Parse(Console.ReadLine() ?? "0"); //The ?? "0" ensures that if the user input is null, it defaults to "0"
            Console.WriteLine("Enter student's first name:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter student's last name:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter enrollment date (yyyy-MM-dd):");
           var enrollmentDate = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString());

    
           var student = new Student(firstName ?? string.Empty, lastName ?? string.Empty, enrollmentDate);//The ?? string.Empty ensures that if firstName/lastName is null, it defaults to an empty string.
             
             var context= new SchoolDbContext(); //new instance of SchoolDbContext
             var studentRepository = new StudentRepository(context);
             
             // Add a new student method
             studentRepository.AddStudent(student);


            // Retrieve all students
            var students = studentRepository.GetAllStudents();
            Console.WriteLine("\nStudents:");
            foreach (var s in students)
            {
                Console.WriteLine($"{s.StudentID}: {s.FirstName} {s.LastName}, Enrolled on {s.EnrollmentDate.ToShortDateString()}");
            }
        }
    }
}









