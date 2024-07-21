

using System.Data;


namespace SchoolEnrollmentApp.Models

{
    public class Student
    {
       
        public Student( int studentId, string firstName, string lastName, DateTime enrollmentDate)
    {
        StudentID= studentId;
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