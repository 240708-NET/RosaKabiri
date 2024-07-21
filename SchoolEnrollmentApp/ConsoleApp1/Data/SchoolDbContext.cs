/*
this class defines Dbset<student> for accessing to student's properties.
the SchoolDbContext inherits from DbContext. DbContext represents a database session that allows 
users to query and save entity instances
*/




using Microsoft.EntityFrameworkCore; // to interact with database
using SchoolEnrollmentApp.Models;



namespace SchoolEnrollmentApp.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options): base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}

