using DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Queries
{
    public interface ICourseQuery
    {
        public IQueryable<Course> GetCourses();

        public Course GetCourseById(int id);

        public Course GetCourseByTitle(string title);
    }
}
