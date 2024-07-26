/*
this class defines Dbset<student> for accessing to student's properties.
the SchoolDbContext inherits from DbContext. DbContext represents a database session that allows 
users to query and save entity instances.
*/


using Microsoft.EntityFrameworkCore; // to interact with database/ includes classes and methods!
using SchoolEnrollmentApp.Models;



namespace SchoolEnrollmentApp.Data
{
    public class SchoolDbContext : DbContext
    {
       public DbSet<Student> Students { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionString = "Server=localhost;Database=SchoolDatabase;User=sa;Password=NotPassword1987!;TrustServerCertificate=true;";
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }


}

