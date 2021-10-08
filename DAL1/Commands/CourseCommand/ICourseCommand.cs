using DAL.Entities;
using DTO;

namespace DAL.Commands
{
    public interface ICourseCommand
    {
        Course CreateCourse(CourseDTO course);

        Course ChangeCourse(int courseId, CourseDTO course);

        bool DeleteCourse(int courseId);
    }
}
