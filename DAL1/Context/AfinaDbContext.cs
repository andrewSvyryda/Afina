using DAL.Entities;
using System.Data.Entity;

namespace DAL.Context
{
    public class AfinaDbContext : DbContext
    {
        public AfinaDbContext()
            : base("name=Model1")
        {

        }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Teacher> Teachers { get; set; }

        public virtual DbSet<Student> Students { get; set; }
    }
}
