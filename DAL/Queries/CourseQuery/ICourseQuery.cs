using DAL.Entities;
using System.Linq;

namespace DAL.Queries
{
    public interface ICourseQuery
    {
        public IQueryable<Course> GetCourses();

        public Course GetCourseById(int id);

        public Course GetCourseByTitle(string title);
    }
}
