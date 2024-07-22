

using System;

namespace SchoolEnrollmentApp.Models
{
    public class Student
    {
        
       
        // Parameterized constructor
        public Student(int studentId, string firstName, string lastName, DateTime enrollmentDate)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First name is required", nameof(firstName));
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Last name is required", nameof(lastName));
            if (enrollmentDate > DateTime.Now)
                throw new ArgumentException("Enrollment date is not valid.", nameof(enrollmentDate));


            StudentID = studentId;
            FirstName = firstName;
            LastName = lastName;
            EnrollmentDate = enrollmentDate;
        }

        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
