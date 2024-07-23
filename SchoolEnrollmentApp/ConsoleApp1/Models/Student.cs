

using System;
using System.ComponentModel.DataAnnotations;
namespace SchoolEnrollmentApp.Models
{
    public class Student
    {
    //Unhandled exception. System.InvalidOperationException:
    // No suitable constructor was found for entity type 'Student'. 
     //The following constructors had parameters that could not be bound to properties of the entity type:       
    //Cannot bind 'studentId' in 'Student(int studentId, 
    //string firstName, string lastName, DateTime enrollmentDate)'
       public Student()
        {
        }
    // constructor and validations
        public Student(int studentId, string? firstName, string? lastName, DateTime enrollmentDate)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First name is required!", nameof(firstName));
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Last name is required!", nameof(lastName));
            if (enrollmentDate > DateTime.Now)
                throw new ArgumentException("Enrollment date is not valid!", nameof(enrollmentDate));


            StudentID = studentId;
            FirstName = firstName;
            LastName = lastName;
            EnrollmentDate = enrollmentDate;
        }

        [Required]
        public int StudentID { get; set; }

        [Required]
        [StringLength(50)]
        public string? FirstName { get; set; }

         [Required]
         [StringLength(50)]
        public string? LastName { get; set; }

         [Required]
        public DateTime EnrollmentDate { get; set; }
    }
}
