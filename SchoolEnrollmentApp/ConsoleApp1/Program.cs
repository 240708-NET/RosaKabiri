/*
cheatsheet: 
Done: dotnet tool install --global dotnet-ef dotnet tool update --global dotnet-ef -- 
Done: create your template app, project, etc... -- 
Done: Add packages to your project 
 ///  dotnet add package Microsoft.EntityFrameworkCore.Design 
///   dotnet add package Microsoft.EntityFrameworkCore.SqlServer -- 
Write your code, create your classes, 
Done: create the DbContext classes --
 we can migrate to the database! 
dotnet ef migrations add <Migration_Name> dotnet ef database update
*/
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

            // Configure services
            // var serviceProvider = new ServiceCollection()
            //     .AddDbContext<SchoolDbContext>(options =>
            //     options.UseSqlServer("Server=localhost;Database=SchoolDatabase;User=sa;Password=NotPassword1987!;TrustServerCertificate=true;"))
            //     .AddScoped<IStudentRepository, StudentRepository>()
            //     .BuildServiceProvider();

            // Resolve the repository
            // var studentRepository = serviceProvider.GetService<IStudentRepository>();

            // Add a new student
            Console.WriteLine("Enter student's ID:");
            var studentId = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter student's first name:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter student's last name:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter enrollment date (yyyy-MM-dd):");
           var enrollmentDate = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString());

    
           var student = new Student(studentId, firstName ?? string.Empty, lastName ?? string.Empty, enrollmentDate);
             
             var context= new SchoolDbContext();
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









