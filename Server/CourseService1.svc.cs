using DAL.Commands;
using DAL.Queries;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace Server
{
    public class CourseService1 : ICourseService1
    {
        public void ChangeCourse(int courseId, CourseDTO course)
        {
            CourseCommand courseCommand = new CourseCommand();

            courseCommand.ChangeCourse(courseId, course);
        }

        public void CreateCourse(CourseDTO course)
        {
            CourseCommand courseCommand = new CourseCommand();

            courseCommand.CreateCourse(course);
        }

        public bool DeleteCourse(int courseId)
        {
            CourseCommand courseCommand = new CourseCommand();

            return courseCommand.DeleteCourse(courseId);
        }

        public List<CourseDTO> GetCourses()
        {
            CourseQuery courseQuery = new CourseQuery();

            return AfinaMapper.Mapper.Map<List<CourseDTO>>(courseQuery.GetCourses().ToList());
        }

        public List<CourseDTO> GetCoursesByTeacherId(int id)
        {
            CourseQuery courseQuery = new CourseQuery();

            var courses = courseQuery.GetCourses();

            return AfinaMapper.Mapper.Map<List<CourseDTO>>(courses.Where(c => c.TeacherId == id));
        }

        public bool Subscribe(int userId, int courseId)
        {
            CourseQuery courseQuery = new CourseQuery();

            var course = courseQuery.GetCourseById(courseId);

            StudentQuery studentQuery = new StudentQuery();

            var student = studentQuery.GetStudent(userId);

            course.Students.Add(student);

            return true;
        }
    }
}
