// for adding a student and get all students

using SchoolEnrollmentApp.Models;
using System.Collections.Generic;

namespace SchoolEnrollmentApp.Repositories
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        IEnumerable<Student> GetAllStudents();
    }
}
