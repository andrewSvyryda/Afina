using DAL.Entities;
using System;
using System.Linq;

namespace DAL.Queries
{
    public class CourseQuery : IDisposable
    {
        public AfinaDbContext context;

        public CourseQuery()
        {
            context = new AfinaDbContext();
        }

        public IQueryable<Course> GetCourses()
        {
            return context.Courses;
        }

        public Course GetCourseById(int id)
        {
            return context.Courses.SingleOrDefault(c => c.Id == id);
        }

        public Course GetCourseByTitle(string title)
        {
            return context.Courses.SingleOrDefault(c => c.Title == title);
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
