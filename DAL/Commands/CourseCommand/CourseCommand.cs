using DAL.Context;
using DAL.DTO;
using DAL.Entities;
using System.Linq;

namespace DAL.Commands
{
    public class CourseCommand : ICourseCommand
    {
        public Course CreateCourse(CourseDTO course)
        {
            if(AfinaContext.Context.Courses.Any(c => c.Title == course.Title))
            {
                return null;
            }

            var createdCourse = AfinaContext.Context.Courses.Add(new Course { Title = course.Title, Description = course.Description }).Entity;

            AfinaContext.Context.SaveChanges();

            return createdCourse;
        }

        public Course ChangeCourse(int courseId, CourseDTO course)
        {
            Course modifiedCourse = AfinaContext.Context.Courses.SingleOrDefault(c => c.Id == courseId);

            if(modifiedCourse == null)
            {
                return null;
            }

            modifiedCourse.Title = course.Title;
            modifiedCourse.Description = course.Description;

            AfinaContext.Context.SaveChanges();

            return modifiedCourse;
        }

        public bool DeleteCourse(int courseId)
        {
            Course courseToDelete = AfinaContext.Context.Courses.SingleOrDefault(c => c.Id == courseId);

            if (courseToDelete == null)
            {
                return false;
            }

            AfinaContext.Context.Courses.Remove(courseToDelete);

            return true;
        }
    }
}
