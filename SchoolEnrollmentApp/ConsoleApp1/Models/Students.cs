

namespace SchoolEnrollingApp.Models // the namespace for the models.
{
    public class Student 
    {
        public int StudentId { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public DateTime DateOfEnrollment{ get; set; } 
      
         public int phoneNumber { get; set; }
        public string email { get; set; }

    }
}