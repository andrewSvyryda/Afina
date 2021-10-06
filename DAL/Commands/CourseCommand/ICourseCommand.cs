using DAL.DTO;
using DAL.Entities;

namespace DAL.Commands
{
    public interface ICourseCommand
    {
        public Course CreateCourse(CourseDTO course);

        public Course ChangeCourse(int courseId, CourseDTO course);

        public bool DeleteCourse(int courseId);
    }
}
