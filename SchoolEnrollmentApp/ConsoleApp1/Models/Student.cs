

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SchoolEnrollmentApp.Models
{
    public class Student
    {
 

    //parameterless constuctor! Parameterless constructor are required by EF!
       public Student()
        {
        }
    // constructor and validations
        public Student(string? firstName, string? lastName, DateTime enrollmentDate)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First name is required!", nameof(firstName));
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Last name is required!", nameof(lastName));
            if (enrollmentDate > DateTime.Now)
                throw new ArgumentException("Enrollment date is not valid!", nameof(enrollmentDate));


            // StudentID = studentId;
            FirstName = firstName;
            LastName = lastName;
            EnrollmentDate = enrollmentDate;
        }

//Properties for columns in the students table.
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
