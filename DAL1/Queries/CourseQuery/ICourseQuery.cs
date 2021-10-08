using DAL.Entities;
using System.Linq;

namespace DAL.Queries
{
    public interface ICourseQuery
    {
        IQueryable<Course> GetCourses();

        Course GetCourseById(int id);

        Course GetCourseByTitle(string title);
    }
}
