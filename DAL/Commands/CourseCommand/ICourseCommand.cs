using DAL.DTO;
using DAL.Entities;
using System;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Commands.CourseCommand
{
    public interface ICourseCommand
    {
        public Course CreateCourse(CourseDTO course);

        public Course ChangeCourse(int courseId, CourseDTO course);

        public void DeleteCourse(int courseId);
    }
}
