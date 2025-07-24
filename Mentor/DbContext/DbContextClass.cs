using Mentor.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mentor
{
    public class DbContextClass : DbContext
    {
       public  DbSet<AboutUsClass> AboutUs { get; set; }
        public DbSet<ContactClass> contacts { get; set; }
         public DbSet<CourseClass> courses { get; set; }
         public DbSet<EventsClass> events { get; set; }
         public DbSet<FeatureClass> features { get; set; }
        public DbSet<FooterClass> footers { get; set; }
        public DbSet<ServicesClass> services { get; set; }
       public  DbSet<StudentClass> students { get; set; }
       public DbSet<TeachersClass> teachers { get; set; }
        public DbSet<AboutCourseClass> aboutCourse { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ASUS\\MYSQLSERVERS;Database=Mentor;User Id=sa;Password=Mehi2006.;TrustServerCertificate=True;Trusted_Connection = True;");
        }



    }

}
