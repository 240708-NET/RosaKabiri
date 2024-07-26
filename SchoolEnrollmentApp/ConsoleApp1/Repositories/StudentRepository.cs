// this class implemets IStudentRepositiry.
//uses SchoolDbContext (communicate with Database) and performs methods for the student.

using Microsoft.EntityFrameworkCore;
using SchoolEnrollmentApp.Data;
using SchoolEnrollmentApp.Models;
using System.Collections.Generic;

namespace SchoolEnrollmentApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolDbContext _context; // make an instance of SchoolDbContext

        public StudentRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges(); 
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.ToList(); 
        }
    }
}
