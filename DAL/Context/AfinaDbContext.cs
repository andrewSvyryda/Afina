using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{

    public class AfinaDbContext : DbContext
    {
        public AfinaDbContext()
        {
            if(Database.EnsureCreated())
            {
                Initializer initializer = new Initializer();

                initializer.Seed(this); 
            }
        }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Teacher> Teachers { get; set; }

        public virtual DbSet<Student> Students { get; set; }
    }
}
