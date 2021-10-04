using DAL.Entities;

namespace DAL
{
    public class Initializer
    {
        public void Seed(AfinaDbContext context)
        {
            var course1 = context.Courses.Add(new Course { Title = "Course 1", Description = "Course description 1" }).Entity;
            var course2 = context.Courses.Add(new Course { Title = "Course 2", Description = "Course description 2" }).Entity;
            var course3 = context.Courses.Add(new Course { Title = "Course 3", Description = "Course description 3" }).Entity;
            var course4 = context.Courses.Add(new Course { Title = "Course 4", Description = "Course description 4" }).Entity;
            var course5 = context.Courses.Add(new Course { Title = "Course 5", Description = "Course description 5" }).Entity;

            context.SaveChanges();
        }
    }
}
