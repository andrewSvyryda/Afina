using DAL.Context;
using DAL.Entities;
using System.Linq;

namespace DAL.Queries
{

    public class CourseQuery : ICourseQuery
    {
        public IQueryable<Course> GetCourses()
        {
            return AfinaContext.Context.Courses;
        }

        public Course GetCourseById(int id)
        {
            return AfinaContext.Context.Courses.SingleOrDefault(c => c.Id == id);
        }

        public Course GetCourseByTitle(string title)
        {
            return AfinaContext.Context.Courses.SingleOrDefault(c => c.Title == title);
        }

        public void Dispose()
        {
            AfinaContext.Context.Dispose();
        }
    }
}
